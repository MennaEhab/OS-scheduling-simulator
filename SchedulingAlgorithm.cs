using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cpu_scheduling
{
    public class SchedulingAlgorithm
    {
        public int count=0;
        public Process[] processArray;
        public SortedDictionary<int, Queue<Process>> readyQueue;
        public Queue finishedQueue;
        public Queue eventQueue;
        public Boolean isPreemptive;
        public int time;
        public Process currentProcess;
        public string mode;
        public int length;
        public SchedulingAlgorithm(Process[] processArray, string mode, int length)
        {
            this.length = length;
            this.processArray = processArray;
            this.mode = mode;
            readyQueue = new SortedDictionary<int, Queue<Process>>();
            finishedQueue = new Queue();
            eventQueue = new Queue();

            time = 0;

            switch (mode)
            {
                case "FCFS":
                    isPreemptive = false;
                    break;

                case "STF":
                    isPreemptive = false;
                    break;
                case "SRTF":
                    isPreemptive = true;
                    break;
                case "P":
                    isPreemptive = false;
                    break;

                case "PP":
                    isPreemptive = true;
                    break;

            }

        }
        public void ProcessArrival(Process process)
        {
            switch (mode)
            {
                case "FCFS":


                    foreach (KeyValuePair<int, Queue<Process>> pair in readyQueue)
                    {

                        if (pair.Key == 1)
                        {

                            Queue<Process> pr = pair.Value;
                            readyQueue.Remove(1);
                            pr.Enqueue(process);
                            readyQueue.Add(1, pr);
                            count++;
                            return;
                        }
                    }
                    Queue<Process> pr1 = new Queue<Process>();
                    pr1.Enqueue(process);
                    readyQueue.Add(1, pr1);
                    count++;


                    break;

                case "STF":


                    foreach (KeyValuePair<int, Queue<Process>> pair in readyQueue)
                    {
                        if (pair.Key == process.cpuBurst)
                        {
                            Queue<Process> pr = pair.Value;
                            readyQueue.Remove(process.cpuBurst);
                            pr.Enqueue(process);
                            readyQueue.Add(process.cpuBurst, pr);
                            count++;
                            return;
                           
                        }
                    }

                    Queue<Process> pr2 = new Queue<Process>();
                    pr2.Enqueue(process);
                    readyQueue.Add(process.cpuBurst, pr2);
                    count++;

                    break;
                case "SRTF":


                    foreach (KeyValuePair<int, Queue<Process>> pair in readyQueue)
                    {
                        if (pair.Key == process.cpuBurst)
                        {
                            Queue<Process> pr = pair.Value;
                            readyQueue.Remove(process.cpuBurst);
                            pr.Enqueue(process);
                            readyQueue.Add(process.cpuBurst, pr);
                            count++;
                            return;
                            
                        }
                    }
                    Queue<Process> pr3 = new Queue<Process>();
                    pr3.Enqueue(process);
                    readyQueue.Add(process.cpuBurst, pr3);

                    count++;

                    break;
                case "P":

                    foreach (KeyValuePair<int, Queue<Process>> pair in readyQueue)
                    {
                        if (pair.Key == process.priorty)
                        {
                            Queue<Process> pr = pair.Value;
                            readyQueue.Remove(process.priorty);
                            pr.Enqueue(process);
                            readyQueue.Add(process.priorty, pr);
                            count++;
                            return;
                        }
                    }
                    Queue<Process> pr4 = new Queue<Process>();
                    pr4.Enqueue(process);
                    readyQueue.Add(process.priorty, pr4);
                    count++;
                    break;



                case "PP":

                    foreach (KeyValuePair<int, Queue<Process>> pair in readyQueue)
                    {
                        if (pair.Key == process.priorty)
                        {
                            Queue<Process> pr = pair.Value;
                            readyQueue.Remove(process.priorty);
                            pr.Enqueue(process);
                            readyQueue.Add(process.priorty, pr);
                            count++;
                            return;
                        }
                    }
                    Queue<Process> pr5 = new Queue<Process>();
                    pr5.Enqueue(process);
                    readyQueue.Add(process.priorty, pr5);
                    count++;
                    break;





            }

        }


        private void CheckForArrival()
        {
            foreach (Process process in processArray)
            {
                if (process.arrivalTime == time)
                {
                    process.Ready();
                    ProcessArrival(process);
                }
            }
        }

        private void CheckForTermination()
        {
            if (currentProcess.IsTerminated())
            {
                CalculateTurnaroundTime();
                eventQueue.Enqueue(currentProcess);

                finishedQueue.Enqueue(currentProcess);
                currentProcess = null;
            }
        }

        private void CalculateWaitingTime()
        {
            currentProcess.waitingTime = currentProcess.waitingTime + currentProcess.startTime - currentProcess.endTime;
            Console.WriteLine(currentProcess.name + " " + currentProcess.waitingTime);
        }

        private void CalculateTurnaroundTime()
        {
            currentProcess.turnaroundTime = currentProcess.waitingTime + currentProcess.cpuBurst;
            currentProcess.endTime = time;
        }

        protected virtual void ProcessLoad()
        {
           
            
                foreach (KeyValuePair<int, Queue<Process>> pair in readyQueue)
                {
                    currentProcess = pair.Value.Dequeue();
                    count--;
                    if (pair.Value.Count == 0)
                    {
                        readyQueue.Remove(pair.Key);
                    }
                    break;
                }
                currentProcess.startTime = time;
                CalculateWaitingTime();
            
        }
        public Boolean SwappingNow()
        {

            Process top = null;

            switch (mode)
            {
                case "SRTF":

                    foreach (KeyValuePair<int, Queue<Process>> pair in readyQueue)
                    {
                        top = pair.Value.Peek();
                        break;
                    }

                    if (top != null && currentProcess != null)
                        return top.cpuBurst < currentProcess.remainingTime;
                    else
                        return false;
                   

                case "PP":


                    foreach (KeyValuePair<int, Queue<Process>> pair in readyQueue)
                    {
                        top = pair.Value.Peek();
                        break;
                    }

                    if (top != null && currentProcess != null)
                        return top.priorty < currentProcess.priorty;
                    else
                        return false;
                    

                default: return false;
            }
        }
        public void CheckForPreemptiveSwap()
        {
            if (isPreemptive)
            {
                if (SwappingNow())
                {
                    CalculateTurnaroundTime();
                    eventQueue.Enqueue(currentProcess.Clone());
                    switch (mode)
                    {
                        case "PP":
                            foreach (KeyValuePair<int, Queue<Process>> pair in readyQueue)
                            {

                                if (currentProcess.priorty == pair.Key)
                                {

                                    Queue<Process> pr = pair.Value;
                                    readyQueue.Remove(currentProcess.priorty);
                                    pr.Enqueue(currentProcess);
                                    readyQueue.Add(currentProcess.priorty, pr);
                                    count++;
                                    currentProcess = null;
                                    return;
                                }

                            }
                            Queue <Process>pr6=new Queue<Process>();
                            pr6.Enqueue(currentProcess);
                            readyQueue.Add(currentProcess.priorty, pr6);
                            count++;
                            currentProcess = null;
                            return;


                        case "SRTF":

                            foreach (KeyValuePair<int, Queue<Process>> pair in readyQueue)
                            {

                                if (currentProcess.remainingTime == pair.Key)
                                {

                                    Queue<Process> pr = pair.Value;
                                    readyQueue.Remove(currentProcess.remainingTime);
                                    pr.Enqueue(currentProcess);
                                    readyQueue.Add(currentProcess.remainingTime, pr);
                                    count++;
                                    currentProcess = null;
                                    return;
                                    
                                }
                            }

                             Queue <Process>pr7=new Queue<Process>();
                            pr7.Enqueue(currentProcess);
                            readyQueue.Add(currentProcess.remainingTime, pr7);
                            count++;
                            currentProcess = null;
                            return;
                    }

                    

                }


            }
        }
        public DataTable GetProcessData()
        {
            DataTable processData = new DataTable();
            processData.Columns.Add("Process Number");
            processData.Columns.Add("Arrival Time");
            processData.Columns.Add("CPU Burst");
            processData.Columns.Add("Waiting Time");
            processData.Columns.Add("Turnaround Time");

            foreach (Process process in finishedQueue)
            {
                processData.Rows.Add(new Object[] { process.name,
                                                    process.arrivalTime,
                                                    process.cpuBurst,
                                                    process.waitingTime,
                                                    process.turnaroundTime });
            }

            return processData;
        }

        public DataTable GetEventData()
        {
            DataTable eventData = new DataTable();
            eventData.Columns.Add("Process Number");
            eventData.Columns.Add("Start Time");
            eventData.Columns.Add("End Time");

            foreach (Process process in eventQueue)
            {
                eventData.Rows.Add(new Object[] { process.name,
                                                  process.startTime,
                                                  process.endTime, });
            }

            return eventData;
        }

        public void Run()
        {
            currentProcess = null;
            while (finishedQueue.Count != processArray.Length)
            {
                CheckForArrival();
                CheckForPreemptiveSwap();
                if ((currentProcess == null) && (count!=0))
                {
                    ProcessLoad();
                }
                if (currentProcess != null)
                {

                    currentProcess.Run();

                    time++;

                    CheckForTermination();
                    

                    

                    

                }
                else
                    time++;

            }

        }

    }

}  

     
    

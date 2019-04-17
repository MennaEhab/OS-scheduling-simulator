using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cpu_scheduling 
{
    public class Process
    {
        public String name { get; private set; }
        public int arrivalTime { get; private set; }
        public int cpuBurst { get; private set; }
        public int remainingTime { get; private set; }
        public int priorty {get ; private set ; }
        public int waitingTime { get; set; }
        public int turnaroundTime { get; set; }
        public int startTime { get; set; }
        public int endTime { get; set; }

        private Boolean isReady;
        private Boolean isRunning;
        private Boolean isTerminated;

        public Process(String name, int arrivalTime, int cpuBurst , int priorty)
        {
            New(name, arrivalTime, cpuBurst , priorty);
            Ready();
        }

        public void New(String name, int arrivalTime, int cpuBurst , int priorty)
        {
            isReady = false;
            isRunning = false;
            isTerminated = false;

            this.name = name;
            this.arrivalTime = arrivalTime;
            this.cpuBurst = cpuBurst;
            this.priorty = priorty;

            remainingTime = cpuBurst;
            endTime = arrivalTime;
        }

        public void Ready()
        {
            isReady = true;
        }

        public void Run()
        {
            isReady = false;
            isRunning = true;

            remainingTime -= 1;
            
            if (remainingTime <= 0)
            {
                isTerminated = true;
                isRunning = false;
            }
        }

        public Process Clone()
        {
            return this.MemberwiseClone() as Process;
        }

        public Boolean IsReady()
        {
            return isReady;
        }

        public Boolean IsRunning()
        {
            return isRunning;
        }

        public Boolean IsTerminated()
        {
            return isTerminated;
        }
    }
}
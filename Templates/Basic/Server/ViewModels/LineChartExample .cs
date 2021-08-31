using System;
using System.Linq;
using System.Reactive.Linq;
using System.Threading;
using Basic.Shared;
using DotNetify;


namespace Basic.Server
{
    public class LineChartExample : BaseVM
    {
        
        public int[] Waveform
        {
            get => Get<int[]>();
            set => Set(value);
        }
  
        public LineChartExample()
        {

            var timer = Observable.Interval(TimeSpan.FromSeconds(1));
            var random = new Random();

            Waveform = Enumerable.Range(1, 8).Select(_ => random.Next(500, 1000)).ToArray();


            timer.Subscribe(x =>
            {
                x += 31;
                this.AddList(nameof(Waveform), new int[] { random.Next(500, 1000) });

                PushUpdates();
            });

        }







    }
}
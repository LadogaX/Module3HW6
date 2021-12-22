using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module3HW6
{
    public class MessageBox
    {
        public event Action<Status> OnStatusHandler;

        public async void Open()
        {
            Console.WriteLine("Window is opened");
            await Task.Delay(3000);
            Console.WriteLine("Window is closed");

            OnStatusHandler?.Invoke((Status)new Random().Next(2));
        }
    }
}

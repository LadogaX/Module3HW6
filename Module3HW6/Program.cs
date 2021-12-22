using System;
using System.Threading.Tasks;

namespace Module3HW6
{
   public class Program
    {
        public static void Main(string[] args)
        {
            var messagebox = new MessageBox();

            var tsc = new TaskCompletionSource();
            messagebox.OnStatusHandler += (status) =>
            {
                string text;

                switch (status)
                {
                    case Status.Ok: text = "Operation is success"; break;
                    case Status.Cancel: text = "Operation is canceled"; break;
                    default: text = "Operation is not depended"; break;
                }

                Console.WriteLine(text);

                tsc.SetResult();
            };

            messagebox.Open();
            tsc.Task.GetAwaiter().GetResult();
        }
    }
}

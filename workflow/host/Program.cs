using System;
using System.Linq;
using System.Activities;
using System.Activities.Statements;
using System.Threading;
using ComplaintManagementSystem_Workflow;
using System.Collections.Generic;

namespace host
{

    class Program
    {
        static void Main(string[] args)
        {
            AutoResetEvent syncEvent = new AutoResetEvent(false);
            AutoResetEvent idleEvent = new AutoResetEvent(false);
            var inputs = new Dictionary<string, object>() { { "CorrDoc", "correct passport" } };
            WorkflowApplication wfApp =
                new WorkflowApplication(new flowchart(), inputs);

            wfApp.Completed = delegate(WorkflowApplicationCompletedEventArgs e)
            {
                //int Turns = Convert.ToInt32(e.Outputs["Turns"]);
                //Console.WriteLine("Congratulations, you guessed the number in {0} turns.", Turns);

                Console.ReadKey();
                syncEvent.Set();
            };

            wfApp.Aborted = delegate(WorkflowApplicationAbortedEventArgs e)
            {
                Console.WriteLine(e.Reason);
                syncEvent.Set();
            };

            wfApp.OnUnhandledException = delegate(WorkflowApplicationUnhandledExceptionEventArgs e)
            {
                Console.WriteLine(e.UnhandledException.ToString());
                return UnhandledExceptionAction.Terminate;
            };

            wfApp.Idle = delegate(WorkflowApplicationIdleEventArgs e)
            {
                idleEvent.Set();
            };
            wfApp.Run();
            WaitHandle[] handles = new WaitHandle[] { syncEvent, idleEvent };
            while (WaitHandle.WaitAny(handles) != 0)
            {
                // Gather the user input and resume the bookmark.
                bool validEntry = false;
                while (!validEntry)
                {
                    string ProvidedDocument;
                    ProvidedDocument = Console.ReadLine();
                    if (String.IsNullOrEmpty(ProvidedDocument))
                    {
                        Console.WriteLine("Please enter correct document, Document Empty.");
                    }
                    else
                    {
                        validEntry = true;
                        wfApp.ResumeBookmark("ProvidedDoc", ProvidedDocument);
                    }
                }
            }
        }
    }
}

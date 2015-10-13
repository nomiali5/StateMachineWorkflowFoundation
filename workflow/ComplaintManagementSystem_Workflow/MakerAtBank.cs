using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Activities;
namespace ComplaintManagementSystem_Workflow
{

    public sealed class MakerAtBank : NativeActivity<string>
    {
        [RequiredArgument]
        public InArgument<string> Document { get; set; }

        protected override void Execute(NativeActivityContext context)
        {
            string name = Document.Get(context);

            if (name == string.Empty || name == null)
            {
                throw new ArgumentException("Please provide correct required document.",
                    "Document");
            }

            context.CreateBookmark(name, new BookmarkCallback(OnReadComplete));
        }

        // NativeActivity derived activities that do asynchronous operations by calling 
        // one of the CreateBookmark overloads defined on System.Activities.NativeActivityContext 
        // must override the CanInduceIdle property and return true.
        protected override bool CanInduceIdle
        {
            get { return true; }
        }

        void OnReadComplete(NativeActivityContext context, Bookmark bookmark, object state)
        {
            this.Result.Set(context, Convert.ToString(state));
        }
    }
}

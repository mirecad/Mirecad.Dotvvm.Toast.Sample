using System.Collections.Generic;

namespace Mirecad.Dotvvm.Toast.Sample.ViewModels
{
    public class DefaultViewModel : MasterPageViewModel
    {
		public string Title { get; set;}

        public List<Model.Toast> Toasts { get; set; } = new List<Model.Toast>();

		public DefaultViewModel()
		{
			Title = "Hello from DotVVM!";
			Toasts.Add(new Model.Toast()
            {
                Content = "toast1"
            });
            Toasts.Add(new Model.Toast()
            {
                Content = "toast2"
            });
        }
    }
}

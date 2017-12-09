using System.Windows.Input;
using Prism.Commands;

namespace ashton.Models
{
	public class TopBarModel
	{
		public ICommand OpenSignUpCommand { get; set; }

		public TopBarModel()
		{
			OpenSignUpCommand = new DelegateCommand(OpenSignUp);
		}

		private void OpenSignUp()
		{
			
		}
	}
}
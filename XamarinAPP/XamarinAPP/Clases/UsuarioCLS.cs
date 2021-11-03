using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace XamarinAPP.Clases
{
	public class UsuarioCLS: INotifyPropertyChanged
	{

		//public string nombreusuario { get; set; }
		//public string contra { get; set; }

		//Creamos una propiedad privada
		private string _nombreusuario { get; set; }
		private string _contra { get; set; }

		public event PropertyChangedEventHandler PropertyChanged;

		//Dinamicas
		public string nombreusuario
		{
			get
			{
				return _nombreusuario;
			}
			set
			{
				if (this._nombreusuario != value)
				{
					this._nombreusuario = value;
					PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(this.nombreusuario)));
				}
			}
		}
		public string contra
		{
			get
			{
				return _contra;
			}
			set
			{
				if (this._contra != value)
				{
					this._contra = value;
					PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(this.contra)));
				}
			}
		}
	}
}


// This file has been generated by the GUI designer. Do not modify.
namespace HollyLibrary
{
	public partial class HColorPicker
	{
		private global::HollyLibrary.HBaseComboBox comboBox;

		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget HollyLibrary.HColorPicker
			global::Stetic.BinContainer.Attach (this);
			this.Name = "HollyLibrary.HColorPicker";
			// Container child HollyLibrary.HColorPicker.Gtk.Container+ContainerChild
			this.comboBox = new global::HollyLibrary.HBaseComboBox ();
			this.comboBox.Events = ((global::Gdk.EventMask)(256));
			this.comboBox.Name = "comboBox";
			this.Add (this.comboBox);
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.Hide ();
		}
	}
}

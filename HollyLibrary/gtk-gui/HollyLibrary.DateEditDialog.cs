
// This file has been generated by the GUI designer. Do not modify.
namespace HollyLibrary
{
	public partial class DateEditDialog
	{
		private global::Gtk.HBox hbox1;
		
		private global::Gtk.VBox vbox2;
		
		private global::Gtk.Calendar CCalendar;
		
		private global::Gtk.HBox hbox2;
		
		private global::Gtk.Button BtnClear;
		
		private global::Gtk.VBox vbox3;
		
		private global::HollyLibrary.AnalogClock Clock;
		
		private global::Gtk.HBox hbox3;
		
		private global::Gtk.Label label4;
		
		private global::Gtk.SpinButton TxtHour;
		
		private global::Gtk.Label label2;
		
		private global::Gtk.SpinButton TxtMin;
		
		private global::Gtk.Label label3;
		
		private global::Gtk.SpinButton TxtSec;

		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget HollyLibrary.DateEditDialog
			this.Name = "HollyLibrary.DateEditDialog";
			this.Title = global::Mono.Unix.Catalog.GetString ("DateEditDialog");
			this.TypeHint = ((global::Gdk.WindowTypeHint)(2));
			this.WindowPosition = ((global::Gtk.WindowPosition)(4));
			this.BorderWidth = ((uint)(1));
			this.Resizable = false;
			this.AllowGrow = false;
			this.Decorated = false;
			this.DestroyWithParent = true;
			this.SkipPagerHint = true;
			this.SkipTaskbarHint = true;
			// Container child HollyLibrary.DateEditDialog.Gtk.Container+ContainerChild
			this.hbox1 = new global::Gtk.HBox ();
			this.hbox1.Name = "hbox1";
			this.hbox1.Spacing = 6;
			this.hbox1.BorderWidth = ((uint)(3));
			// Container child hbox1.Gtk.Box+BoxChild
			this.vbox2 = new global::Gtk.VBox ();
			this.vbox2.Name = "vbox2";
			this.vbox2.Spacing = 6;
			// Container child vbox2.Gtk.Box+BoxChild
			this.CCalendar = new global::Gtk.Calendar ();
			this.CCalendar.CanFocus = true;
			this.CCalendar.Name = "CCalendar";
			this.CCalendar.DisplayOptions = ((global::Gtk.CalendarDisplayOptions)(3));
			this.vbox2.Add (this.CCalendar);
			global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.CCalendar]));
			w1.Position = 0;
			// Container child vbox2.Gtk.Box+BoxChild
			this.hbox2 = new global::Gtk.HBox ();
			this.hbox2.Name = "hbox2";
			this.hbox2.Homogeneous = true;
			this.hbox2.Spacing = 6;
			// Container child hbox2.Gtk.Box+BoxChild
			this.BtnClear = new global::Gtk.Button ();
			this.BtnClear.CanFocus = true;
			this.BtnClear.Name = "BtnClear";
			this.BtnClear.UseUnderline = true;
			this.BtnClear.Label = global::Mono.Unix.Catalog.GetString ("Now");
			global::Gtk.Image w2 = new global::Gtk.Image ();
			w2.Pixbuf = global::Stetic.IconLoader.LoadIcon (this, "gtk-clear", global::Gtk.IconSize.Menu);
			this.BtnClear.Image = w2;
			this.hbox2.Add (this.BtnClear);
			global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.hbox2 [this.BtnClear]));
			w3.Position = 0;
			this.vbox2.Add (this.hbox2);
			global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.hbox2]));
			w4.Position = 1;
			w4.Expand = false;
			w4.Fill = false;
			this.hbox1.Add (this.vbox2);
			global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.vbox2]));
			w5.Position = 0;
			w5.Expand = false;
			w5.Fill = false;
			// Container child hbox1.Gtk.Box+BoxChild
			this.vbox3 = new global::Gtk.VBox ();
			this.vbox3.Name = "vbox3";
			this.vbox3.Spacing = 6;
			// Container child vbox3.Gtk.Box+BoxChild
			this.Clock = new global::HollyLibrary.AnalogClock ();
			this.Clock.Name = "Clock";
			this.Clock.Datetime = new global::System.DateTime (0);
			this.vbox3.Add (this.Clock);
			global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.vbox3 [this.Clock]));
			w6.Position = 0;
			// Container child vbox3.Gtk.Box+BoxChild
			this.hbox3 = new global::Gtk.HBox ();
			this.hbox3.Name = "hbox3";
			this.hbox3.Spacing = 6;
			// Container child hbox3.Gtk.Box+BoxChild
			this.label4 = new global::Gtk.Label ();
			this.label4.Name = "label4";
			this.label4.LabelProp = global::Mono.Unix.Catalog.GetString ("H:");
			this.hbox3.Add (this.label4);
			global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.hbox3 [this.label4]));
			w7.Position = 0;
			w7.Expand = false;
			w7.Fill = false;
			// Container child hbox3.Gtk.Box+BoxChild
			this.TxtHour = new global::Gtk.SpinButton (0D, 24D, 1D);
			this.TxtHour.CanFocus = true;
			this.TxtHour.Name = "TxtHour";
			this.TxtHour.Adjustment.PageIncrement = 1D;
			this.TxtHour.ClimbRate = 1D;
			this.TxtHour.Numeric = true;
			this.hbox3.Add (this.TxtHour);
			global::Gtk.Box.BoxChild w8 = ((global::Gtk.Box.BoxChild)(this.hbox3 [this.TxtHour]));
			w8.Position = 1;
			w8.Expand = false;
			w8.Fill = false;
			// Container child hbox3.Gtk.Box+BoxChild
			this.label2 = new global::Gtk.Label ();
			this.label2.Name = "label2";
			this.label2.LabelProp = global::Mono.Unix.Catalog.GetString ("M:");
			this.hbox3.Add (this.label2);
			global::Gtk.Box.BoxChild w9 = ((global::Gtk.Box.BoxChild)(this.hbox3 [this.label2]));
			w9.Position = 2;
			w9.Expand = false;
			w9.Fill = false;
			// Container child hbox3.Gtk.Box+BoxChild
			this.TxtMin = new global::Gtk.SpinButton (0D, 60D, 1D);
			this.TxtMin.CanFocus = true;
			this.TxtMin.Name = "TxtMin";
			this.TxtMin.Adjustment.PageIncrement = 10D;
			this.TxtMin.ClimbRate = 1D;
			this.TxtMin.Numeric = true;
			this.hbox3.Add (this.TxtMin);
			global::Gtk.Box.BoxChild w10 = ((global::Gtk.Box.BoxChild)(this.hbox3 [this.TxtMin]));
			w10.Position = 3;
			w10.Expand = false;
			w10.Fill = false;
			// Container child hbox3.Gtk.Box+BoxChild
			this.label3 = new global::Gtk.Label ();
			this.label3.Name = "label3";
			this.label3.LabelProp = global::Mono.Unix.Catalog.GetString ("S:");
			this.hbox3.Add (this.label3);
			global::Gtk.Box.BoxChild w11 = ((global::Gtk.Box.BoxChild)(this.hbox3 [this.label3]));
			w11.Position = 4;
			w11.Expand = false;
			w11.Fill = false;
			// Container child hbox3.Gtk.Box+BoxChild
			this.TxtSec = new global::Gtk.SpinButton (0D, 60D, 1D);
			this.TxtSec.CanFocus = true;
			this.TxtSec.Name = "TxtSec";
			this.TxtSec.Adjustment.PageIncrement = 10D;
			this.TxtSec.ClimbRate = 1D;
			this.TxtSec.Numeric = true;
			this.hbox3.Add (this.TxtSec);
			global::Gtk.Box.BoxChild w12 = ((global::Gtk.Box.BoxChild)(this.hbox3 [this.TxtSec]));
			w12.Position = 5;
			w12.Expand = false;
			w12.Fill = false;
			this.vbox3.Add (this.hbox3);
			global::Gtk.Box.BoxChild w13 = ((global::Gtk.Box.BoxChild)(this.vbox3 [this.hbox3]));
			w13.Position = 1;
			w13.Expand = false;
			this.hbox1.Add (this.vbox3);
			global::Gtk.Box.BoxChild w14 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.vbox3]));
			w14.Position = 1;
			w14.Expand = false;
			w14.Fill = false;
			this.Add (this.hbox1);
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.DefaultWidth = 491;
			this.DefaultHeight = 263;
			this.Show ();
			this.ButtonPressEvent += new global::Gtk.ButtonPressEventHandler (this.OnButtonPressEvent);
			this.CCalendar.ButtonPressEvent += new global::Gtk.ButtonPressEventHandler (this.OnCalendar4ButtonPressEvent);
			this.CCalendar.DaySelected += new global::System.EventHandler (this.OnCCalendarDaySelected);
			this.CCalendar.DaySelectedDoubleClick += new global::System.EventHandler (this.OnCCalendarDaySelectedDoubleClick);
			this.BtnClear.Clicked += new global::System.EventHandler (this.OnBtnClearClicked);
			this.TxtHour.ValueChanged += new global::System.EventHandler (this.OnTxtHourValueChanged);
			this.TxtHour.ButtonPressEvent += new global::Gtk.ButtonPressEventHandler (this.OnTxtHourButtonPressEvent);
			this.TxtMin.ValueChanged += new global::System.EventHandler (this.OnTxtMinValueChanged);
			this.TxtMin.ButtonPressEvent += new global::Gtk.ButtonPressEventHandler (this.OnTxtMinButtonPressEvent);
			this.TxtSec.ValueChanged += new global::System.EventHandler (this.OnTxtSecValueChanged);
			this.TxtSec.ButtonPressEvent += new global::Gtk.ButtonPressEventHandler (this.OnTxtSecButtonPressEvent);
		}
	}
}

// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      Mono Runtime Version: 2.0.50727.42
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------



public partial class MainWindow {
    
    private Gtk.VBox vbox1;
    
    private HollyLibrary.HComboFolder hcombofolder2;
    
    private HollyLibrary.HLabel hlabel1;
    
    private HollyLibrary.HDateEdit hdateedit2;
    
    private HollyLibrary.HFontPicker hfontpicker1;
    
    protected virtual void Build() {
        Stetic.Gui.Initialize(this);
        // Widget MainWindow
        this.Name = "MainWindow";
        this.Title = "MainWindow";
        this.WindowPosition = ((Gtk.WindowPosition)(4));
        // Container child MainWindow.Gtk.Container+ContainerChild
        this.vbox1 = new Gtk.VBox();
        this.vbox1.Name = "vbox1";
        this.vbox1.Spacing = 6;
        // Container child vbox1.Gtk.Box+BoxChild
        this.hcombofolder2 = new HollyLibrary.HComboFolder();
        this.hcombofolder2.Events = ((Gdk.EventMask)(256));
        this.hcombofolder2.Name = "hcombofolder2";
        this.hcombofolder2.DropDownHeight = 0;
        this.vbox1.Add(this.hcombofolder2);
        Gtk.Box.BoxChild w1 = ((Gtk.Box.BoxChild)(this.vbox1[this.hcombofolder2]));
        w1.Position = 0;
        w1.Expand = false;
        w1.Fill = false;
        // Container child vbox1.Gtk.Box+BoxChild
        this.hlabel1 = new HollyLibrary.HLabel();
        this.hlabel1.Name = "hlabel1";
        this.hlabel1.LabelProp = "hlabel1";
        this.hlabel1.TextOverwritesIcon = false;
        this.hlabel1.HorizontalLine = false;
        this.hlabel1.TextInSelectionRectangle = false;
        this.vbox1.Add(this.hlabel1);
        Gtk.Box.BoxChild w2 = ((Gtk.Box.BoxChild)(this.vbox1[this.hlabel1]));
        w2.Position = 1;
        w2.Expand = false;
        w2.Fill = false;
        // Container child vbox1.Gtk.Box+BoxChild
        this.hdateedit2 = new HollyLibrary.HDateEdit();
        this.hdateedit2.Events = ((Gdk.EventMask)(256));
        this.hdateedit2.Name = "hdateedit2";
        this.hdateedit2.CurrentDate = new System.DateTime(0);
        this.vbox1.Add(this.hdateedit2);
        Gtk.Box.BoxChild w3 = ((Gtk.Box.BoxChild)(this.vbox1[this.hdateedit2]));
        w3.Position = 2;
        w3.Expand = false;
        w3.Fill = false;
        // Container child vbox1.Gtk.Box+BoxChild
        this.hfontpicker1 = new HollyLibrary.HFontPicker();
        this.hfontpicker1.Events = ((Gdk.EventMask)(256));
        this.hfontpicker1.Name = "hfontpicker1";
        this.vbox1.Add(this.hfontpicker1);
        Gtk.Box.BoxChild w4 = ((Gtk.Box.BoxChild)(this.vbox1[this.hfontpicker1]));
        w4.Position = 3;
        w4.Expand = false;
        w4.Fill = false;
        this.Add(this.vbox1);
        if ((this.Child != null)) {
            this.Child.ShowAll();
        }
        this.DefaultWidth = 577;
        this.DefaultHeight = 400;
        this.Show();
        this.DeleteEvent += new Gtk.DeleteEventHandler(this.OnDeleteEvent);
    }
}

// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

namespace Mono.Upnp.GtkClient {
    
    
    public partial class RawXmlInfo {
        
        private Gtk.ScrolledWindow scrolledwindow1;
        
        private Gtk.VBox vbox1;
        
        private Gtk.TextView raw;
        
        protected virtual void Build() {
            Stetic.Gui.Initialize(this);
            // Widget Mono.Upnp.GtkClient.RawXmlInfo
            Stetic.BinContainer.Attach(this);
            this.Name = "Mono.Upnp.GtkClient.RawXmlInfo";
            // Container child Mono.Upnp.GtkClient.RawXmlInfo.Gtk.Container+ContainerChild
            this.scrolledwindow1 = new Gtk.ScrolledWindow();
            this.scrolledwindow1.CanFocus = true;
            this.scrolledwindow1.Name = "scrolledwindow1";
            this.scrolledwindow1.ShadowType = ((Gtk.ShadowType)(1));
            // Container child scrolledwindow1.Gtk.Container+ContainerChild
            Gtk.Viewport w1 = new Gtk.Viewport();
            w1.ShadowType = ((Gtk.ShadowType)(0));
            // Container child GtkViewport.Gtk.Container+ContainerChild
            this.vbox1 = new Gtk.VBox();
            this.vbox1.Name = "vbox1";
            this.vbox1.Spacing = 6;
            // Container child vbox1.Gtk.Box+BoxChild
            this.raw = new Gtk.TextView();
            this.raw.CanFocus = true;
            this.raw.Name = "raw";
            this.raw.Editable = false;
            this.vbox1.Add(this.raw);
            Gtk.Box.BoxChild w2 = ((Gtk.Box.BoxChild)(this.vbox1[this.raw]));
            w2.Position = 0;
            w1.Add(this.vbox1);
            this.scrolledwindow1.Add(w1);
            this.Add(this.scrolledwindow1);
            if ((this.Child != null)) {
                this.Child.ShowAll();
            }
            this.Hide();
        }
    }
}
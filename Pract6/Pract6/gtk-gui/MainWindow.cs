
// This file has been generated by the GUI designer. Do not modify.

public partial class MainWindow
{
	private global::Gtk.Fixed fixed1;
	private global::Gtk.Entry entry1;
	private global::Gtk.Label producto1;
	private global::Gtk.Entry entry2;
	private global::Gtk.Label producto3;
	private global::Gtk.Entry entry3;
	private global::Gtk.Entry entry4;
	private global::Gtk.Entry entry5;
	private global::Gtk.Entry entry6;
	private global::Gtk.Label TOTAL;
	private global::Gtk.Label IVA;
	private global::Gtk.Label subtotal;
	private global::Gtk.Label producto2;
	private global::Gtk.Button LIMPIAR;
	private global::Gtk.Button FACTURAR;
	
	protected virtual void Build ()
	{
		global::Stetic.Gui.Initialize (this);
		// Widget MainWindow
		this.Name = "MainWindow";
		this.Title = global::Mono.Unix.Catalog.GetString ("MainWindow");
		this.WindowPosition = ((global::Gtk.WindowPosition)(4));
		// Container child MainWindow.Gtk.Container+ContainerChild
		this.fixed1 = new global::Gtk.Fixed ();
		this.fixed1.Name = "fixed1";
		this.fixed1.HasWindow = false;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.entry1 = new global::Gtk.Entry ();
		this.entry1.CanFocus = true;
		this.entry1.Name = "entry1";
		this.entry1.IsEditable = true;
		this.entry1.InvisibleChar = '•';
		this.fixed1.Add (this.entry1);
		global::Gtk.Fixed.FixedChild w1 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.entry1]));
		w1.X = 151;
		w1.Y = 27;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.producto1 = new global::Gtk.Label ();
		this.producto1.Name = "producto1";
		this.producto1.LabelProp = global::Mono.Unix.Catalog.GetString ("producto1");
		this.fixed1.Add (this.producto1);
		global::Gtk.Fixed.FixedChild w2 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.producto1]));
		w2.X = 58;
		w2.Y = 28;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.entry2 = new global::Gtk.Entry ();
		this.entry2.CanFocus = true;
		this.entry2.Name = "entry2";
		this.entry2.IsEditable = true;
		this.entry2.InvisibleChar = '•';
		this.fixed1.Add (this.entry2);
		global::Gtk.Fixed.FixedChild w3 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.entry2]));
		w3.X = 154;
		w3.Y = 69;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.producto3 = new global::Gtk.Label ();
		this.producto3.Name = "producto3";
		this.producto3.LabelProp = global::Mono.Unix.Catalog.GetString ("producto3");
		this.fixed1.Add (this.producto3);
		global::Gtk.Fixed.FixedChild w4 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.producto3]));
		w4.X = 53;
		w4.Y = 109;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.entry3 = new global::Gtk.Entry ();
		this.entry3.CanFocus = true;
		this.entry3.Name = "entry3";
		this.entry3.IsEditable = true;
		this.entry3.InvisibleChar = '•';
		this.fixed1.Add (this.entry3);
		global::Gtk.Fixed.FixedChild w5 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.entry3]));
		w5.X = 154;
		w5.Y = 115;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.entry4 = new global::Gtk.Entry ();
		this.entry4.CanFocus = true;
		this.entry4.Name = "entry4";
		this.entry4.IsEditable = true;
		this.entry4.InvisibleChar = '•';
		this.fixed1.Add (this.entry4);
		global::Gtk.Fixed.FixedChild w6 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.entry4]));
		w6.X = 202;
		w6.Y = 179;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.entry5 = new global::Gtk.Entry ();
		this.entry5.CanFocus = true;
		this.entry5.Name = "entry5";
		this.entry5.IsEditable = true;
		this.entry5.InvisibleChar = '•';
		this.fixed1.Add (this.entry5);
		global::Gtk.Fixed.FixedChild w7 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.entry5]));
		w7.X = 205;
		w7.Y = 216;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.entry6 = new global::Gtk.Entry ();
		this.entry6.CanFocus = true;
		this.entry6.Name = "entry6";
		this.entry6.IsEditable = true;
		this.entry6.InvisibleChar = '•';
		this.fixed1.Add (this.entry6);
		global::Gtk.Fixed.FixedChild w8 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.entry6]));
		w8.X = 207;
		w8.Y = 257;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.TOTAL = new global::Gtk.Label ();
		this.TOTAL.Name = "TOTAL";
		this.TOTAL.LabelProp = global::Mono.Unix.Catalog.GetString ("TOTAL");
		this.fixed1.Add (this.TOTAL);
		global::Gtk.Fixed.FixedChild w9 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.TOTAL]));
		w9.X = 129;
		w9.Y = 256;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.IVA = new global::Gtk.Label ();
		this.IVA.Name = "IVA";
		this.IVA.LabelProp = global::Mono.Unix.Catalog.GetString ("IVA");
		this.fixed1.Add (this.IVA);
		global::Gtk.Fixed.FixedChild w10 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.IVA]));
		w10.X = 132;
		w10.Y = 222;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.subtotal = new global::Gtk.Label ();
		this.subtotal.Name = "subtotal";
		this.subtotal.LabelProp = global::Mono.Unix.Catalog.GetString ("subtotal");
		this.fixed1.Add (this.subtotal);
		global::Gtk.Fixed.FixedChild w11 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.subtotal]));
		w11.X = 127;
		w11.Y = 185;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.producto2 = new global::Gtk.Label ();
		this.producto2.Name = "producto2";
		this.producto2.LabelProp = global::Mono.Unix.Catalog.GetString ("producto2");
		this.fixed1.Add (this.producto2);
		global::Gtk.Fixed.FixedChild w12 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.producto2]));
		w12.X = 52;
		w12.Y = 73;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.LIMPIAR = new global::Gtk.Button ();
		this.LIMPIAR.CanFocus = true;
		this.LIMPIAR.Name = "LIMPIAR";
		this.LIMPIAR.UseUnderline = true;
		this.LIMPIAR.Label = global::Mono.Unix.Catalog.GetString ("LIMPIAR");
		this.fixed1.Add (this.LIMPIAR);
		global::Gtk.Fixed.FixedChild w13 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.LIMPIAR]));
		w13.X = 300;
		w13.Y = 309;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.FACTURAR = new global::Gtk.Button ();
		this.FACTURAR.CanFocus = true;
		this.FACTURAR.Name = "FACTURAR";
		this.FACTURAR.UseUnderline = true;
		this.FACTURAR.Label = global::Mono.Unix.Catalog.GetString ("FACTURAR");
		this.fixed1.Add (this.FACTURAR);
		global::Gtk.Fixed.FixedChild w14 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.FACTURAR]));
		w14.X = 208;
		w14.Y = 309;
		this.Add (this.fixed1);
		if ((this.Child != null)) {
			this.Child.ShowAll ();
		}
		this.DefaultWidth = 400;
		this.DefaultHeight = 390;
		this.Show ();
		this.DeleteEvent += new global::Gtk.DeleteEventHandler (this.OnDeleteEvent);
		this.LIMPIAR.Clicked += new global::System.EventHandler (this.OnLIMPIARClicked);
		this.FACTURAR.Clicked += new global::System.EventHandler (this.OnFACTURARClicked);
	}
}
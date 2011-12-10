using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Data;
using System.Windows.Forms;
using System.IO;
using System.Reflection;
using System.Collections.Generic;

namespace MyControlLibrary
{
   /// <summary>
   /// Summary description for UserControl1.
   /// </summary>
   public class TabCtlEx : System.Windows.Forms.TabControl
   {
      /// <summary>
      /// Required designer variable.
      /// </summary>
      private System.ComponentModel.Container components = null;
      public delegate void OnHeaderCloseDelegate(object sender,CloseEventArgs e);
      public event OnHeaderCloseDelegate OnClose;

      public TabCtlEx()
      {
         // This call is required by the Windows.Forms Form Designer.
         InitializeComponent();
         this.TabStop = false;
         
         
         // TODO: Add any initialization after the InitComponent call

      }
      private bool confirmOnClose = true;
      public bool ConfirmOnClose
      {
         get
         {
            return this.confirmOnClose;
         }
         set
         {
            this.confirmOnClose = value;
         }
      }

      /// <summary>
      /// Clean up any resources being used.
      /// </summary>
      protected override void Dispose( bool disposing )
      {
         if( disposing )
         {
            if( components != null )
               components.Dispose();
         }
         base.Dispose( disposing );
      }
       

      #region Component Designer generated code
      /// <summary>
      /// Required method for Designer support - do not modify 
      /// the contents of this method with the code editor.
      /// </summary>
      private void InitializeComponent()
      {
         components = new System.ComponentModel.Container();
         SetStyle(System.Windows.Forms.ControlStyles.DoubleBuffer,true);
         this.TabStop = false;
         this.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
         this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.ItemSize = new System.Drawing.Size(230, 24);
         //this.Controls.Add(this.btnClose); 
      }
      #endregion
      private Stream GetContentFromResource(string filename)
      {
         Assembly asm = Assembly.GetExecutingAssembly();
         Stream stream =  asm.GetManifestResourceStream("MyControlLibrary."+filename); 
         return stream;
          
      }
    
      protected override void OnDrawItem(DrawItemEventArgs e)
      {

          if (e.Bounds != RectangleF.Empty)
          {
              e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

              RectangleF tabTextArea = RectangleF.Empty;

              for (int nIndex = 0; nIndex < this.TabCount; nIndex++)
              {
                  if (nIndex != this.SelectedIndex)
                  {
                      tabTextArea = (RectangleF)this.GetTabRect(nIndex);
                      GraphicsPath _Path = new GraphicsPath();
                      _Path.AddRectangle(tabTextArea);
                      using (LinearGradientBrush _Brush = new LinearGradientBrush(tabTextArea, SystemColors.Control, SystemColors.ControlLight, LinearGradientMode.Vertical))
                      {
                          ColorBlend _ColorBlend = new ColorBlend(3);
                          _ColorBlend.Colors = new Color[]{SystemColors.ControlLightLight, 
                                                      Color.FromArgb(255,SystemColors.ControlLight),SystemColors.ControlDark,
                                                      SystemColors.ControlLightLight};

                          _ColorBlend.Positions = new float[] { 0f, .4f, 0.5f, 1f };
                          _Brush.InterpolationColors = _ColorBlend;

                          e.Graphics.FillPath(_Brush, _Path);
                          using (Pen pen = new Pen(SystemColors.ActiveBorder))
                          {
                              e.Graphics.DrawPath(pen, _Path);
                          }


                          _ColorBlend.Colors = new Color[]{  SystemColors.ActiveBorder, 
                                                        SystemColors.ActiveBorder,SystemColors.ActiveBorder,
                                                        SystemColors.ActiveBorder};

                          _ColorBlend.Positions = new float[] { 0f, .4f, 0.5f, 1f };
                          _Brush.InterpolationColors = _ColorBlend;
                            e.Graphics.FillRectangle(_Brush, tabTextArea.X + tabTextArea.Width - 22, 4, tabTextArea.Height - 3, tabTextArea.Height - 5);
                            e.Graphics.DrawRectangle(Pens.White, tabTextArea.X + tabTextArea.Width - 20, 6, tabTextArea.Height - 8, tabTextArea.Height - 9);
                          using (Pen pen = new Pen(Color.White, 2))
                          {
                              e.Graphics.DrawLine(pen, tabTextArea.X + tabTextArea.Width - 16, 9, tabTextArea.X + tabTextArea.Width - 7, 17);
                              e.Graphics.DrawLine(pen, tabTextArea.X + tabTextArea.Width - 16, 17, tabTextArea.X + tabTextArea.Width - 7, 9);
                          }
                          if (CanDrawMenuButton(nIndex))
                          {
                              _ColorBlend.Positions = new float[] { 0f, .4f, 0.5f, 1f };
                              _Brush.InterpolationColors = _ColorBlend;
                              _ColorBlend.Positions = new float[] { 0f, .4f, 0.5f, 1f };
                              // assign the color blend to the pathgradientbrush
                              _Brush.InterpolationColors = _ColorBlend;

                               e.Graphics.FillRectangle(_Brush, tabTextArea.X + tabTextArea.Width - 43, 4, tabTextArea.Height - 3, tabTextArea.Height - 5);
                             // e.Graphics.DrawRectangle(SystemPens.GradientInactiveCaption, tabTextArea.X + tabTextArea.Width - 37, 7, 13, 13);
                              e.Graphics.DrawRectangle(new Pen(Color.White), tabTextArea.X + tabTextArea.Width - 41, 6, tabTextArea.Height - 7, tabTextArea.Height - 9);
                              using (Pen pen = new Pen(Color.White, 2))
                              {
                                  e.Graphics.DrawLine(pen, tabTextArea.X + tabTextArea.Width - 36, 11, tabTextArea.X + tabTextArea.Width - 33, 16);
                                  e.Graphics.DrawLine(pen, tabTextArea.X + tabTextArea.Width - 33, 16, tabTextArea.X + tabTextArea.Width - 30, 11);
                              }
                          }
                      }
                      _Path.Dispose();

                  }
                  else
                  {

                      tabTextArea = (RectangleF)this.GetTabRect(nIndex);
                      GraphicsPath _Path = new GraphicsPath();
                      _Path.AddRectangle(tabTextArea);
                      using (LinearGradientBrush _Brush = new LinearGradientBrush(tabTextArea, SystemColors.Control, SystemColors.ControlLight, LinearGradientMode.Vertical))
                      {
                          ColorBlend _ColorBlend = new ColorBlend(3);
                          _ColorBlend.Colors = new Color[]{SystemColors.ControlLightLight, 
                                                      Color.FromArgb(255,SystemColors.Control),SystemColors.ControlLight,
                                                      SystemColors.Control};
                          _ColorBlend.Positions = new float[] { 0f, .4f, 0.5f, 1f };
                          _Brush.InterpolationColors = _ColorBlend;
                          e.Graphics.FillPath(_Brush, _Path);
                          using (Pen pen = new Pen(SystemColors.ActiveBorder))
                          {
                              e.Graphics.DrawPath(pen, _Path);
                          }
                          //Drawing Close Button
                          _ColorBlend.Colors = new Color[]{Color.FromArgb(255,231,164,152), 
                                                      Color.FromArgb(255,231,164,152),Color.FromArgb(255,197,98,79),
                                                      Color.FromArgb(255,197,98,79)};
                          _Brush.InterpolationColors = _ColorBlend;
                          e.Graphics.FillRectangle(_Brush, tabTextArea.X + tabTextArea.Width - 22, 4, tabTextArea.Height - 3, tabTextArea.Height - 5);
                          e.Graphics.DrawRectangle(Pens.White, tabTextArea.X + tabTextArea.Width - 20, 6, tabTextArea.Height - 8, tabTextArea.Height - 9);
                          using (Pen pen = new Pen(Color.White, 2))
                          {
                              e.Graphics.DrawLine(pen, tabTextArea.X + tabTextArea.Width - 16, 9, tabTextArea.X + tabTextArea.Width - 7, 17);
                              e.Graphics.DrawLine(pen, tabTextArea.X + tabTextArea.Width - 16, 17, tabTextArea.X + tabTextArea.Width - 7, 9);
                          }
                          if (CanDrawMenuButton(nIndex))
                          {
                              //Drawing menu button
                              _ColorBlend.Colors = new Color[]{SystemColors.ControlLightLight, 
                                                     Color.FromArgb(255,SystemColors.ControlLight),SystemColors.ControlDark,
                                                     SystemColors.ControlLightLight};
                              _ColorBlend.Positions = new float[] { 0f, .4f, 0.5f, 1f };
                              _Brush.InterpolationColors = _ColorBlend;
                              _ColorBlend.Colors = new Color[]{Color.FromArgb(255,170,213,243), 
                                                      Color.FromArgb(255,170,213,243),Color.FromArgb(255,44,137,191),
                                                      Color.FromArgb(255,44,137,191)};
                              _Brush.InterpolationColors = _ColorBlend;
                              e.Graphics.FillRectangle(_Brush, tabTextArea.X + tabTextArea.Width - 43, 4, tabTextArea.Height - 3, tabTextArea.Height - 5);
                              e.Graphics.DrawRectangle(Pens.White, tabTextArea.X + tabTextArea.Width - 41, 6, tabTextArea.Height - 7, tabTextArea.Height - 9);
                              using (Pen pen = new Pen(Color.White, 2))
                              {
                                  e.Graphics.DrawLine(pen, tabTextArea.X + tabTextArea.Width - 36, 11, tabTextArea.X + tabTextArea.Width - 33, 16);
                                  e.Graphics.DrawLine(pen, tabTextArea.X + tabTextArea.Width - 33, 16, tabTextArea.X + tabTextArea.Width - 30, 11);
                              }
                          }
                      }
                      _Path.Dispose();
                  }
                  string str = this.TabPages[nIndex].Text;
                  StringFormat stringFormat = new StringFormat();
                  stringFormat.Alignment = StringAlignment.Center;
                  e.Graphics.DrawString(str, this.Font, new SolidBrush(this.TabPages[nIndex].ForeColor), tabTextArea, stringFormat);


              }
          }

      }
      
      private bool CanDrawMenuButton(int nIndex)
      {
          try
          {
              if (((CharTabPage)this.TabPages[nIndex]).Menu != null)
                  return true;
              return false;
          }
          catch
          {
              return false;
          }
      }
      protected override void OnMouseLeave(EventArgs e)
      {
         Graphics g = CreateGraphics();
         g.SmoothingMode = SmoothingMode.AntiAlias;
         RectangleF tabTextArea = RectangleF.Empty;
         for (int nIndex = 0; nIndex < this.TabCount; nIndex++)
         {
             if (nIndex != this.SelectedIndex)
             {
                 tabTextArea = (RectangleF)this.GetTabRect(nIndex);
                 GraphicsPath _Path = new GraphicsPath();
                 _Path.AddRectangle(tabTextArea);
                 using (LinearGradientBrush _Brush = new LinearGradientBrush(tabTextArea, SystemColors.Control, SystemColors.ControlLight, LinearGradientMode.Vertical))
                 {
                     ColorBlend _ColorBlend = new ColorBlend(3);
                     
                     _ColorBlend.Colors = new Color[]{  SystemColors.ActiveBorder, 
                                                        SystemColors.ActiveBorder,SystemColors.ActiveBorder,
                                                        SystemColors.ActiveBorder};

                     _ColorBlend.Positions = new float[] { 0f, .4f, 0.5f, 1f };
                     _Brush.InterpolationColors = _ColorBlend;
                     g.FillRectangle(_Brush, tabTextArea.X + tabTextArea.Width - 22, 4, tabTextArea.Height - 2, tabTextArea.Height - 5);
                     g.DrawRectangle(Pens.White, tabTextArea.X + tabTextArea.Width - 20, 6, tabTextArea.Height - 8, tabTextArea.Height - 9);
                     using (Pen pen = new Pen(Color.White, 2))
                     {
                         g.DrawLine(pen, tabTextArea.X + tabTextArea.Width - 16, 9, tabTextArea.X + tabTextArea.Width - 7, 17);
                         g.DrawLine(pen, tabTextArea.X + tabTextArea.Width - 16, 17, tabTextArea.X + tabTextArea.Width - 7, 9);
                     }
                     if (CanDrawMenuButton(nIndex))
                     {
                         _ColorBlend.Positions = new float[] { 0f, .4f, 0.5f, 1f };
                         // assign the color blend to the pathgradientbrush
                         _Brush.InterpolationColors = _ColorBlend;

                         g.FillRectangle(_Brush, tabTextArea.X + tabTextArea.Width - 43, 4, tabTextArea.Height - 3, tabTextArea.Height - 5);
                         // e.Graphics.DrawRectangle(SystemPens.GradientInactiveCaption, tabTextArea.X + tabTextArea.Width - 37, 7, 13, 13);
                         g.DrawRectangle(new Pen(Color.White), tabTextArea.X + tabTextArea.Width - 41, 6, tabTextArea.Height - 7, tabTextArea.Height - 9);
                         using (Pen pen = new Pen(Color.White, 2))
                         {
                             g.DrawLine(pen, tabTextArea.X + tabTextArea.Width - 36, 11, tabTextArea.X + tabTextArea.Width - 33, 16);
                             g.DrawLine(pen, tabTextArea.X + tabTextArea.Width - 33, 16, tabTextArea.X + tabTextArea.Width - 30, 11);
                         }
                     }
                 }
                 _Path.Dispose();

             }
             else
             {

                 tabTextArea = (RectangleF)this.GetTabRect(nIndex);
                 GraphicsPath _Path = new GraphicsPath();
                 _Path.AddRectangle(tabTextArea);
                 using (LinearGradientBrush _Brush = new LinearGradientBrush(tabTextArea, SystemColors.Control, SystemColors.ControlLight, LinearGradientMode.Vertical))
                 {
                     ColorBlend _ColorBlend = new ColorBlend(3);
                     _ColorBlend.Positions = new float[] { 0f, .4f, 0.5f, 1f };
                
                     _ColorBlend.Colors = new Color[]{Color.FromArgb(255,231,164,152), 
                                                      Color.FromArgb(255,231,164,152),Color.FromArgb(255,197,98,79),
                                                      Color.FromArgb(255,197,98,79)};
                     _Brush.InterpolationColors = _ColorBlend;
                     g.FillRectangle(_Brush, tabTextArea.X + tabTextArea.Width - 22, 4, tabTextArea.Height - 3, tabTextArea.Height - 5);
                     g.DrawRectangle(Pens.White, tabTextArea.X + tabTextArea.Width - 20, 6, tabTextArea.Height - 8, tabTextArea.Height - 9);
                     using (Pen pen = new Pen(Color.White, 2))
                     {
                         g.DrawLine(pen, tabTextArea.X + tabTextArea.Width - 16, 9, tabTextArea.X + tabTextArea.Width - 7, 17);
                         g.DrawLine(pen, tabTextArea.X + tabTextArea.Width - 16, 17, tabTextArea.X + tabTextArea.Width - 7, 9);
                     }
                     if (CanDrawMenuButton(nIndex))
                     {
                         //Drawing menu button
                         _ColorBlend.Colors = new Color[]{SystemColors.ControlLightLight, 
                                                     Color.FromArgb(255,SystemColors.ControlLight),SystemColors.ControlDark,
                                                     SystemColors.ControlLightLight};
                         _ColorBlend.Positions = new float[] { 0f, .4f, 0.5f, 1f };
                         _Brush.InterpolationColors = _ColorBlend;
                         _ColorBlend.Colors = new Color[]{Color.FromArgb(255,170,213,243), 
                                                      Color.FromArgb(255,170,213,243),Color.FromArgb(255,44,137,191),
                                                      Color.FromArgb(255,44,137,191)};
                         _Brush.InterpolationColors = _ColorBlend;
                         g.FillRectangle(_Brush, tabTextArea.X + tabTextArea.Width - 43, 4, tabTextArea.Height - 3, tabTextArea.Height - 5);
                         g.DrawRectangle(Pens.White, tabTextArea.X + tabTextArea.Width - 41, 6, tabTextArea.Height - 7, tabTextArea.Height - 9);
                         using (Pen pen = new Pen(Color.White, 2))
                         {
                             g.DrawLine(pen, tabTextArea.X + tabTextArea.Width - 36, 11, tabTextArea.X + tabTextArea.Width - 33, 16);
                             g.DrawLine(pen, tabTextArea.X + tabTextArea.Width - 33, 16, tabTextArea.X + tabTextArea.Width - 30, 11);
                         }
                     }
                 }
                 _Path.Dispose();
             }
             
         }

         g.Dispose();           
       
        
      }
       
      protected override void OnMouseMove(MouseEventArgs e)
      {

          if (!DesignMode)
          {
              Graphics g = CreateGraphics();
              g.SmoothingMode = SmoothingMode.AntiAlias;
              for (int nIndex = 0; nIndex < this.TabCount; nIndex++)
              {
                  RectangleF tabTextArea = (RectangleF) this.GetTabRect(nIndex);
                  tabTextArea =
                      new RectangleF(tabTextArea.X + tabTextArea.Width - 22, 4, tabTextArea.Height - 3,
                                     tabTextArea.Height - 5);
                 
                  Point pt = new Point(e.X, e.Y);
                  if (tabTextArea.Contains(pt))
                  {
                      using (
                          LinearGradientBrush _Brush =
                              new LinearGradientBrush(tabTextArea, SystemColors.Control, SystemColors.ControlLight,
                                                      LinearGradientMode.Vertical))
                      {
                          ColorBlend _ColorBlend = new ColorBlend(3);
                          _ColorBlend.Colors = new Color[]
                              {
                                  Color.FromArgb(255, 252, 193, 183),
                                  Color.FromArgb(255, 252, 193, 183), Color.FromArgb(255, 210, 35, 2),
                                  Color.FromArgb(255, 210, 35, 2)
                              };
                          _ColorBlend.Positions = new float[] {0f, .4f, 0.5f, 1f};
                          _Brush.InterpolationColors = _ColorBlend;

                          g.FillRectangle(_Brush, tabTextArea);
                          g.DrawRectangle(Pens.White, tabTextArea.X + 2, 6, tabTextArea.Height - 3,
                                          tabTextArea.Height - 4);
                          using (Pen pen = new Pen(Color.White, 2))
                          {
                              g.DrawLine(pen, tabTextArea.X + 6, 9, tabTextArea.X + 15, 17);
                              g.DrawLine(pen, tabTextArea.X + 6, 17, tabTextArea.X + 15, 9);
                          }
                      }
                  }
                  else
                  {
                      if (nIndex != SelectedIndex)
                      {
                          using (
                              LinearGradientBrush _Brush =
                                  new LinearGradientBrush(tabTextArea, SystemColors.Control, SystemColors.ControlLight,
                                                          LinearGradientMode.Vertical))
                          {
                              ColorBlend _ColorBlend = new ColorBlend(3);
                              _ColorBlend.Colors = new Color[]
                                  {
                                      SystemColors.ActiveBorder,
                                      SystemColors.ActiveBorder, SystemColors.ActiveBorder,
                                      SystemColors.ActiveBorder
                                  };
                              _ColorBlend.Positions = new float[] {0f, .4f, 0.5f, 1f};
                              _Brush.InterpolationColors = _ColorBlend;

                              g.FillRectangle(_Brush, tabTextArea);
                              g.DrawRectangle(Pens.White, tabTextArea.X + 2, 6, tabTextArea.Height - 3,
                                              tabTextArea.Height - 4);
                              using (Pen pen = new Pen(Color.White, 2))
                              {
                                  g.DrawLine(pen, tabTextArea.X + 6, 9, tabTextArea.X + 15, 17);
                                  g.DrawLine(pen, tabTextArea.X + 6, 17, tabTextArea.X + 15, 9);
                              }
                          }
                      }
                  }
                  if (CanDrawMenuButton(nIndex) )
                  {
                      RectangleF tabMenuArea = (RectangleF) this.GetTabRect(nIndex);
                      tabMenuArea =
                          new RectangleF(tabMenuArea.X + tabMenuArea.Width - 43, 4, tabMenuArea.Height - 3,
                                         tabMenuArea.Height - 5);
                      pt = new Point(e.X, e.Y);
                      if (tabMenuArea.Contains(pt))
                      {
                          using (
                              LinearGradientBrush _Brush =
                                  new LinearGradientBrush(tabMenuArea, SystemColors.Control, SystemColors.ControlLight,
                                                          LinearGradientMode.Vertical))
                          {
                              ColorBlend _ColorBlend = new ColorBlend(3);
                              _ColorBlend.Colors = new Color[]
                                  {
                                      Color.FromArgb(255, 170, 213, 255),
                                      Color.FromArgb(255, 170, 213, 255), Color.FromArgb(255, 44, 157, 250),
                                      Color.FromArgb(255, 44, 157, 250)
                                  };
                              _ColorBlend.Positions = new float[] {0f, .4f, 0.5f, 1f};
                              _Brush.InterpolationColors = _ColorBlend;

                              g.FillRectangle(_Brush, tabMenuArea);
                              g.DrawRectangle(Pens.White, tabMenuArea.X + 2, 6, tabMenuArea.Height - 2,
                                              tabMenuArea.Height - 4);
                              using (Pen pen = new Pen(Color.White, 2))
                              {
                                  g.DrawLine(pen, tabMenuArea.X + 7, 11, tabMenuArea.X + 10, 16);
                                  g.DrawLine(pen, tabMenuArea.X + 10, 16, tabMenuArea.X + 13, 11);
                              }
                          }
                      }
                      else
                      {
                          if (nIndex != SelectedIndex)
                          {
                              using (
                                  LinearGradientBrush _Brush =
                                      new LinearGradientBrush(tabMenuArea, SystemColors.Control,
                                                              SystemColors.ControlLight, LinearGradientMode.Vertical))
                              {
                                  ColorBlend _ColorBlend = new ColorBlend(3);
                                  _ColorBlend.Colors = new Color[]
                                      {
                                          SystemColors.ActiveBorder,
                                          SystemColors.ActiveBorder, SystemColors.ActiveBorder,
                                          SystemColors.ActiveBorder
                                      };
                                  _ColorBlend.Positions = new float[] {0f, .4f, 0.5f, 1f};
                                  _Brush.InterpolationColors = _ColorBlend;

                                  g.FillRectangle(_Brush, tabMenuArea);
                                  g.DrawRectangle(Pens.White, tabMenuArea.X + 2, 6, tabMenuArea.Height - 2,
                                                  tabMenuArea.Height - 4);
                                  using (Pen pen = new Pen(Color.White, 2))
                                  {
                                      g.DrawLine(pen, tabMenuArea.X + 7, 11, tabMenuArea.X + 10, 16);
                                      g.DrawLine(pen, tabMenuArea.X + 10, 16, tabMenuArea.X + 13, 11);
                                  }
                              }
                          }
                      }
                  }
                  
              }
              g.Dispose();
          }
      }

      protected override void OnMouseDown(MouseEventArgs e)
      {
          if (!DesignMode)
          {
              RectangleF tabTextArea = (RectangleF) this.GetTabRect(SelectedIndex);
              tabTextArea =
                  tabTextArea =
                  new RectangleF(tabTextArea.X + tabTextArea.Width - 22, 4, tabTextArea.Height - 3,
                                 tabTextArea.Height - 5);
              Point pt = new Point(e.X, e.Y);
              if (tabTextArea.Contains(pt))
              {
                  if (confirmOnClose)
                  {
                      if (
                          MessageBox.Show(
                              "You are about to close " + this.TabPages[SelectedIndex].Text.TrimEnd() +
                              " tab. Are you sure you want to continue?", "Confirm close", MessageBoxButtons.YesNo) ==
                          DialogResult.No)
                          return;
                  }
                  //Fire Event to Client
                  if (OnClose != null)
                  {
                      OnClose(this, new CloseEventArgs(SelectedIndex));
                  }
              }
              if (CanDrawMenuButton(SelectedIndex))
              {
                  RectangleF tabMenuArea = (RectangleF) this.GetTabRect(SelectedIndex);
                  tabMenuArea =
                      new RectangleF(tabMenuArea.X + tabMenuArea.Width - 43, 4, tabMenuArea.Height - 3,
                                     tabMenuArea.Height - 5);
                  pt = new Point(e.X, e.Y);
                  if (tabMenuArea.Contains(pt))
                  {
                      if (((CharTabPage) this.TabPages[SelectedIndex]).Menu != null)
                      {
                          ((CharTabPage) this.TabPages[SelectedIndex]).Menu.Show(this,
                                                                               new Point((int) tabMenuArea.X,
                                                                                         (int)
                                                                                         (tabMenuArea.Y +
                                                                                          tabMenuArea.Height)));
                      }
                  }
              }
          }
      }
   }

   public class CloseEventArgs:EventArgs
   {
      private int nTabIndex = -1;
      public CloseEventArgs(int nTabIndex)
      {
         this.nTabIndex = nTabIndex;
      }
      /// <summary>
      /// Get/Set the tab index value where the close button is clicked
      /// </summary>
      public int TabIndex 
      {
         get
         {
            return this.nTabIndex;
         }
         set
         {
            this.nTabIndex = value;
         }
      }
   
   }
}

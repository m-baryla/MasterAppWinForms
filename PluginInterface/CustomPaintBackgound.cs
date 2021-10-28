using System.Drawing;
using System.Windows.Forms;

namespace PluginInterface
{
	public static class CustomPaintBackgound
	{
		public static void PanelBackgruondPanit(UserControl panel, PaintEventArgs e, System.Drawing.Drawing2D.LinearGradientMode linearGradientMode)
		{
			if (e == null)
				return;
			if (e.Graphics == null)
				return;

			Graphics g = e.Graphics;
			System.Drawing.Rectangle rect = new Rectangle(0, 0, panel.Size.Width, panel.Size.Height);
			
			System.Drawing.Color color = panel.BackColor; ;

			Color[] colorArray = null;
			float[] positionArray = null;
			
			colorArray = new Color[]{
									 Blend(panel.BackColor,System.Drawing.Color.White,60),
									 Blend(panel.BackColor,System.Drawing.Color.White,30),
									 Blend(panel.BackColor,System.Drawing.Color.Black,0),
									 Blend(panel.BackColor,System.Drawing.Color.Black,0),
									 Blend(panel.BackColor,System.Drawing.Color.White,30),
									 Blend(panel.BackColor,System.Drawing.Color.White,60),
				};
			positionArray = new float[] { 0.0f, .05f, .40f, .60f, .95f, 1.0f };
	
			System.Drawing.Drawing2D.ColorBlend blend = new System.Drawing.Drawing2D.ColorBlend();
			blend.Colors = colorArray;
			blend.Positions = positionArray;
		
			System.Drawing.Drawing2D.LinearGradientBrush brush = new System.Drawing.Drawing2D.LinearGradientBrush(rect, panel.BackColor, Blend(panel.BackColor, panel.BackColor, 10), linearGradientMode);
			brush.InterpolationColors = blend;
		
			g.FillRectangle(brush, rect);
			
			brush.Dispose();
		}


		//public static void ButtonBackgruondPanit(Button buttton, PaintEventArgs e, System.Drawing.Drawing2D.LinearGradientMode linearGradientMode)
		//{
		//	if (e == null)
		//		return;
		//	if (e.Graphics == null)
		//		return;

		//	Graphics g = e.Graphics;
		//	System.Drawing.Rectangle rect = new Rectangle(0, 0, buttton.Size.Width, buttton.Size.Height);
		//	//
		//	// get color of background
		//	//			
		//	System.Drawing.Color color = buttton.BackColor; ;
		//	//
		//	// intialize ColorArray and Positions Array
		//	//
		//	Color[] ColorArray = null;
		//	float[] PositionArray = null;
		//	//
		//	// initialize color array for a button that is pushed
		//	//			
		//	ColorArray = new Color[]{
		//							 Blend(buttton.BackColor,System.Drawing.Color.White,80),
		//							 Blend(buttton.BackColor,System.Drawing.Color.White,40),
		//							 Blend(buttton.BackColor,System.Drawing.Color.Black,0),
		//							 Blend(buttton.BackColor,System.Drawing.Color.Black,0),
		//							 Blend(buttton.BackColor,System.Drawing.Color.White,40),
		//							 Blend(buttton.BackColor,System.Drawing.Color.White,80),
		//		};
		//	PositionArray = new float[] { 0.0f, .05f, .40f, .60f, .95f, 1.0f };
		//	//
		//	//
		//	// create blend variable for the interpolate the colors
		//	//
		//	System.Drawing.Drawing2D.ColorBlend blend = new System.Drawing.Drawing2D.ColorBlend();
		//	blend.Colors = ColorArray;
		//	blend.Positions = PositionArray;
		//	//
		//	// create vertical gradient brush
		//	//
		//	System.Drawing.Drawing2D.LinearGradientBrush brush = new System.Drawing.Drawing2D.LinearGradientBrush(rect, buttton.BackColor, Blend(buttton.BackColor, buttton.BackColor, 10), linearGradientMode);

		//	brush.InterpolationColors = blend;
		//	//
		//	// fill the rectangle
		//	//
		//	g.FillRectangle(brush, rect);
		//	//
		//	// release resources
		//	//
		//	brush.Dispose();
		//}

		private static Color Blend(Color sColor, Color dColor, int percentage)
		{
			int r = sColor.R + ((dColor.R - sColor.R) * percentage) / 100;
			int g = sColor.G + ((dColor.G - sColor.G) * percentage) / 100;
			int b = sColor.B + ((dColor.B - sColor.B) * percentage) / 100;
			return Color.FromArgb(r, g, b);
		}
	}
}

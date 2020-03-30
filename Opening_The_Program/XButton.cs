using System.Drawing;
using System.Windows.Forms;

namespace Opening_The_Program
{
    public class XButton : Button
    {
        public XButton()
        {
            UseVisualStyleBackColor = false;
        }
        public override string Text
        {
            get { return ""; }
            set { base.Text = value; }
        }

        public string NameRecipe { get; set; }
        public string FullNameRecipe { get; set; }
        public string СookingTime { get; set; }
        public string СookingTimeText { get; set; }
        public string EvaluationOfTaste { get; set; }
        public string EvaluationOfTasteText { get; set; }


        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);

            Rectangle СookingTimeTextParam = ClientRectangle;
            СookingTimeTextParam.X = 5; СookingTimeTextParam.Y = 7;

            Rectangle СookingTimeParam = ClientRectangle;
            СookingTimeParam.X = 130; СookingTimeParam.Y = 7;

            Rectangle NameRecipeParam = ClientRectangle;
            NameRecipeParam.X = 5; NameRecipeParam.Y = 28;

            Rectangle EvaluationOfTasteTextParam = ClientRectangle;
            EvaluationOfTasteTextParam.X = 15; EvaluationOfTasteTextParam.Y = 49;

            Rectangle EvaluationOfTasteParam = ClientRectangle;
            EvaluationOfTasteParam.X = 130; EvaluationOfTasteParam.Y = 49;

            using (StringFormat sf = new StringFormat() )
            {
                using (Brush brush = new SolidBrush(ForeColor))
                {
                    pevent.Graphics.DrawString(СookingTimeText, Font, brush, СookingTimeTextParam, sf);
                    pevent.Graphics.DrawString(СookingTime, Font, brush, СookingTimeParam, sf);

                    pevent.Graphics.DrawString(NameRecipe, Font, brush, NameRecipeParam, sf);

                    pevent.Graphics.DrawString(EvaluationOfTasteText, Font, brush, EvaluationOfTasteTextParam, sf);
                    pevent.Graphics.DrawString(EvaluationOfTaste, Font, brush, EvaluationOfTasteParam, sf);
                }
            }
        }
    }
}

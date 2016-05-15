using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
/**********************************************************************************     
     * Created by  Yao  on  5/15/2016 10:35:20 AM     
     * README:滑动控制
     * ============================================================================
     * CHANGELOG：
    ********************************************************************************/
namespace iCarto.common.utils
{
    public class SlidingManager
    {
        //自定义待操作控件
        private Control c1;
        private Control c2;
        //待操作控件的坐标
        private int c1X;
        private int c1Y;
        private int c2X;
        private int c2Y;

        //自定义滑动次数
        private int slidingTimes;

        //每次滑动的步长
        private double increment = 0.00;

        //待滑动的总长度
        private double slidingFullLength = 0.00;

        //已滑动的步长
        private double slidedLength = 0.00;


        /// <summary>
        /// 构造函数初始化滑动参数
        /// </summary>
        /// <param name="control1">控件1</param>
        /// <param name="control2">控件2</param>
        /// <param name="times">滑动次数</param>
        public SlidingManager(Control crlControl1, Control crlControl2, int intTimes)
        {
            c1 = crlControl1;
            c2 = crlControl2;

            c1X = c1.Location.X;
            c1Y = c1.Location.Y;
            c2X = c2.Location.X;
            c2Y = c2.Location.Y;

            slidingTimes = intTimes;


        }

        public SlidingManager(Control control1, Control control2) : this(control1, control2, 10) { }



        public void SlidingLeft()
        {
            Timer timer;
            timer = new Timer();
            timer.Interval = 10;
            timer.Tick += new EventHandler(timer_Tick_Left);
            timer.Start();

            slidingFullLength = c1X - c2X;
            increment = slidingFullLength / slidingTimes;

            if (slidedLength < slidingFullLength)
            {
                c1.Location = new Point(c1.Location.X - (int)(increment), c1.Location.Y);
                c2.Location = new Point(c2.Location.X - (int)(increment), c2.Location.Y);
                slidedLength += increment;
            }
            else
            {
                timer.Stop();
            }

        }
        public void SlidingRight()
        {
            Timer timer;
            timer = new Timer();
            timer.Interval = 10;
            timer.Tick += new EventHandler(timer_Tick_Right);
            timer.Start();


            slidingFullLength = c1X - c2X;
            increment = slidingFullLength / slidingTimes;

            if (slidedLength < slidingFullLength)
            {
                c1.Location = new Point(c1.Location.X + (int)(increment), c1.Location.Y);
                c2.Location = new Point(c2.Location.X + (int)(increment), c2.Location.Y);
                slidedLength += increment;
            }
            else
            {
                timer.Stop();
            }
        }


        void timer_Tick_Left(object sender, EventArgs e)
        {
            SlidingLeft();

        }

        void timer_Tick_Right(object sender, EventArgs e)
        {
            SlidingRight();

        }

    }
}
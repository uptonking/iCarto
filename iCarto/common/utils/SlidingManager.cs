using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using iCarto.common.consts;

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
        //待滑动的总长度
        private int slidingFullLength;
        //每次滑动的步长
        private int increment;
        //已滑动的步长
        private int slidedLength;

        //计时器System.Windows.Forms.Timer
        Timer timer;

        /// <summary>
        /// 构造函数初始化滑动参数
        /// </summary>
        /// <param name="crlControl1">控件1</param>
        /// <param name="crlControl2">控件2</param>
        /// <param name="intTimes">滑动次数</param>
        public SlidingManager(Control crlControl1, Control crlControl2, int intTimes)
        {
            c1 = crlControl1;
            c2 = crlControl2;

            c1X = c1.Location.X;
            c1Y = c1.Location.Y;
            c2X = c2.Location.X;
            c2Y = c2.Location.Y;

            slidingTimes = intTimes;

            //MessageBox.Show((c1X - c2X).ToString());

        }

        /// <summary>
        /// 构造函数：默认滑动200次
        /// </summary>
        public SlidingManager(Control control1, Control control2) : this(control1, control2, 50) { }


        /// <summary>
        /// 方法：根据输入方向执行timer事件，默认计时间隔为1/1000s
        /// </summary>
        /// <param name="strDirection">方向枚举</param>
        public void startSliding(DirectionEnum strDirection)
        {

            timer = new Timer();
            timer.Interval = 1;
            switch (strDirection)
            {
                case DirectionEnum.LEFT_TO_RIGHT:
                    timer.Tick += new EventHandler(timer_Tick_Right);
                    break;
                case DirectionEnum.RIGHT_TO_LEFT:
                    timer.Tick += new EventHandler(timer_Tick_Left);
                    break;

                default:
                    MessageBox.Show("滑动的方向参数错误");
                    break;
            }

            timer.Start();

        }


        /// <summary>
        /// c1，c2同时左滑
        /// </summary>
        public void SlidingLeft()
        {

            slidingFullLength = c1X - c2X;
            increment = slidingFullLength / slidingTimes;

            if (slidedLength < slidingFullLength)
            {
                c1.Location = new Point(c1.Location.X - increment, c1.Location.Y);

                c2.Location = new Point(c2.Location.X - increment, c2.Location.Y);
                slidedLength += increment;

            }
            else
            {
                timer.Dispose();
            }

        }


        /// <summary>
        /// c1，c2同时右滑
        /// </summary>
        public void SlidingRight()
        {
            slidingFullLength = c1X - c2X;
            increment = slidingFullLength / slidingTimes;

            if (slidedLength < slidingFullLength)
            {
                c1.Location = new Point(c1.Location.X + increment, c1.Location.Y);
                c2.Location = new Point(c2.Location.X + increment, c2.Location.Y);
                slidedLength += increment;
            }
            else
            {
                timer.Dispose();
            }
        }


        /// <summary>
        /// timer左滑事件
        /// </summary>
        void timer_Tick_Left(object sender, EventArgs e)
        {
            SlidingLeft();
        }


        /// <summary>
        /// timer右滑事件
        /// </summary>
        void timer_Tick_Right(object sender, EventArgs e)
        {
            SlidingRight();
        }

    }
}
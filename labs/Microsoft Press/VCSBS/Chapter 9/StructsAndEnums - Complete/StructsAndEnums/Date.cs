using System;

namespace StructsAndEnums
{
    struct Date
    {
        private int year;
        private Month month;
        private int day;

        public Date(int ccyy, Month mm, int dd)
        {
            this.year = ccyy - 1900;//century
            this.month = mm;//month
            this.day = dd - 1;//day
        }

        public override string ToString()
        {
            string data = $"{this.month} {this.day + 1} {this.year + 1900}";
            return data;
        }

        public void AdvanceMonth()
        {
            month++;
            if(month == Month.December + 1)
            {
                month = Month.January;
                year++;
            }
        }
    }
}

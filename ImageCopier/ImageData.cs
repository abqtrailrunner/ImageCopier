using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageCopier
{
    class ImageData : IComparable<ImageData>
    {
        private string mOriginalPath;
        private DateTime mDateTaken;
        private long mFileLength;

        public string OriginalPath
        {
            get { return mOriginalPath; }
            set { mOriginalPath = value; }
        }

        public DateTime DateTaken
        {
            get { return mDateTaken; }
            set { mDateTaken = Convert.ToDateTime(value); }
        }

        public ImageData(string path, string dateTaken, long length)
        {
            mOriginalPath = path;
            mDateTaken = Convert.ToDateTime(dateTaken);
            mFileLength = length;
        }

        public DateTime ParseDateTime()
        {
            return Convert.ToDateTime(mDateTaken);
        }

        public int CompareTo(ImageData other)
        {
            //  If we somehow got exactly the same path, then they are the same.
            if (mOriginalPath.CompareTo(other.mOriginalPath) == 0)
                return 0;

            int yearDiff = mDateTaken.Year - other.mDateTaken.Year;
            if (yearDiff != 0)
                return yearDiff;

            int monthDiff = mDateTaken.Month - other.mDateTaken.Month;
            if (monthDiff != 0)
                return monthDiff;

            int dayDiff = mDateTaken.Day - other.mDateTaken.Day;
            if (dayDiff != 0)
                return dayDiff;

            int timeDiff = mDateTaken.TimeOfDay.CompareTo(other.mDateTaken.TimeOfDay);
            if (timeDiff != 0)
                return timeDiff;

            return (int)(mFileLength - other.mFileLength);
        }
    }
}

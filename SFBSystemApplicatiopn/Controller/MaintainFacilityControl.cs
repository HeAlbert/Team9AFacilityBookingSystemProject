using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;

namespace SFBSystemApplicatiopn
{
    public class MaintainFacilityControl
    {
        private frmMaintainSportsFacility maintainFacility;
        private frmSearchFacility searchFacility;

        /* 1. define EntityFrame Work 
           2. define the Constructor in order for UI to get the same Ent
        */
        SportsFacilityBookingEntities1 ent = new SportsFacilityBookingEntities1();
        public SportsFacilityBookingEntities1 Ent
        {
            get { return ent; }
        }


        public void selectsearchFacility()
        {
            searchFacility = new frmSearchFacility(this);
            searchFacility.Show();
        }
        public void selctmaintainFacility()
        {
            maintainFacility = new frmMaintainSportsFacility(this);
            maintainFacility.Show();
        }
        public void GetSpecFacilityInfo(int i)
        {
            
            var q = from x in ent.SportFacilities where x.SportFacilityID == i select x;
            SportFacility s = q.First();
            var sportTypeq = from x in ent.SportTypes select x;
            List<SportType> sl = sportTypeq.ToList();
            maintainFacility.AcceptSpecFacilityInfo(s,sl);
        }
        public void GetSportTypeInfo()
        {
            //SportsFacilityBookingEntities1 ent = new SportsFacilityBookingEntities1();
            var sportTypeq = from x in ent.SportTypes select x;
            List<SportType> s = sportTypeq.ToList();
            searchFacility.AcceptSportTypeInfo(s);
        }
        public void GetFacilityInfo(string i)
        {
            int d = Convert.ToInt32(i);
            //SportsFacilityBookingEntities1 ent = new SportsFacilityBookingEntities1();
            var sportFacilityq = from y in ent.SportFacilities where y.SportTypeID == d select y;
            List<SportFacility> s = sportFacilityq.ToList();
            searchFacility.AcceptFacilityInfo(s);
        }

        public byte[] ImageToByte(Image image)
        {
            ImageFormat format = image.RawFormat;
            using (MemoryStream ms = new MemoryStream())
            {
                if (format.Equals(ImageFormat.Jpeg))
                {
                    image.Save(ms, ImageFormat.Jpeg);
                }
                else if (format.Equals(ImageFormat.Png))
                {
                    image.Save(ms, ImageFormat.Png);
                }
                else if (format.Equals(ImageFormat.Bmp))
                {
                    image.Save(ms, ImageFormat.Bmp);
                }
                else if (format.Equals(ImageFormat.Gif))
                {
                    image.Save(ms, ImageFormat.Gif);
                }
                else if (format.Equals(ImageFormat.Icon))
                {
                    image.Save(ms, ImageFormat.Icon);
                }
                byte[] buffer = new byte[ms.Length];
                ms.Seek(0, SeekOrigin.Begin);
                ms.Read(buffer, 0, buffer.Length);
                return buffer;
            }
        }
        // convert byte[] to image
        public Image ByteToImage(byte[] buffer)
        {
            
            MemoryStream ms = new MemoryStream(buffer);
            Image image = System.Drawing.Image.FromStream(ms);
            return image;
        }

        public void SelectSave()
        {
            //6. Just to save the change 
            ent.SaveChanges();
        }

    }
    
}

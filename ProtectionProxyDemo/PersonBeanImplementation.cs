using System;
using System.Collections.Generic;
using System.Text;

namespace ProtectionProxyDemo
{
    public class PersonBeanImplementation : PersonBean
    {
        string name;
        string gender;
        string interests;
        int rating;
        int ratingCount = 0;

        public string getGender()
        {
            return gender;
        }

        public int getHotOrNotRating()
        {
            if (ratingCount == 0) return 0;
            return rating / ratingCount;
        }

        public string getInterests()
        {
            return interests;
        }

        public string getName()
        {
            return name;
        }

        public void setGender(string gender)
        {
            this.gender = gender;
        }

        public void setHotOrNotRating(int rating)
        {
            this.rating += rating;
            ratingCount++;
        }

        public void setInterests(string interests)
        {
            this.interests = interests;
        }

        public void setName(string name)
        {
            this.name = name;
        }
    }
}

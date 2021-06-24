using System;
using System.Collections.Generic;
using System.Text;

namespace ProtectionProxyDemo
{
    public interface PersonBean
    {
        string getName();
        string getGender();
        string getInterests();
        int getHotOrNotRating();

        void setName(string name);
        void setGender(string gender);
        void setInterests(string interests);
        void setHotOrNotRating(int rating);
    }
}

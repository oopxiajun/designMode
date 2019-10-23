using System;
using System.Collections.Generic;
using System.Text;

namespace Mediator_中介者模式.Example_1
{
    public class WomenMatchMaker
    {
        private Matcher mMan;
        private Matcher mWomen;

        public WomenMatchMaker(Matcher man, Matcher women)
        {
            mMan = man;
            mWomen = women;
        }
        /// <summary>
        /// 男方信息
        /// </summary>
        public void OfferManInformation()
        {
            mWomen.mFavor = -mWomen.mAge * 200 + mWomen.mMoney + mWomen.mFamilyBG;
            Console.WriteLine("把男生信息提供给女孩之后,女孩的好感度:" + mWomen.mFavor);
        }
        /// <summary>
        /// 男方信息
        /// </summary>
        public void OfferWoManInformation()
        {
            mMan.mFavor = mMan.mAge + mMan.mMoney + mMan.mFamilyBG;
            Console.WriteLine("把女孩信息提供给男生之后,男生的好感度:" + mMan.mFavor);
        }
    }
}

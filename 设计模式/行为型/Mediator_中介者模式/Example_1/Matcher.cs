using System;
using System.Collections.Generic;
using System.Text;

namespace Mediator_中介者模式.Example_1
{
    public abstract class Matcher
    { //这里为了方便处理,全部采用了int类型
        public int mAge;//年龄
        public int mMoney;//财富值
        public int mFamilyBG;//家庭背景

        public int mFavor;//好感度
        public Matcher(int age, int money, int familuBG, int favor)
        {
            mAge = age;
            mMoney = money;
            mFamilyBG = familuBG;
            mFavor = favor;
        }
    }
}

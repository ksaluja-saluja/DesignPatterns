using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    public interface IRobot
    {
        void DisplayFeatures();
    }

    public interface ICanTalk
    {
        string CanTalk();
    }

    public class CanTalkInEnglish : ICanTalk
    {
        public string CanTalk()
        {
            return "I can talk in English";
        }
    }

    public class CanTalkInFrench : ICanTalk
    {
        public string CanTalk()
        {
            return "I can talk in French";
        }
    }

    public class CanNotTalk : ICanTalk
    {
        public string CanTalk()
        {
            return "Sorry I cannot talk!!";
        }
    }

    public class Robot : IRobot
    {
        ICanTalk TalkingAbility = null;

        public Robot(ICanTalk Talker)
        {
            TalkingAbility = Talker;
        }

        public void DisplayFeatures()
        {
            Console.WriteLine("Talking Ability: " + TalkingAbility.CanTalk());
        }
    }

    class Strategy
    {
    }
}

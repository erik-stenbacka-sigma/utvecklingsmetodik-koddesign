using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DRYDemo
{
    class Communicator
    {
        private void sendVoice(User user, String fromNumber) { }
        private void storeVoiceMessage(User user, String fromNumber) { }
        private void sendTextMessageWithSound(User user, String message) { }
        private void sendTextMessageWithoutSound(User user, String message) { }
        public void contactByVoice(User user, String fromNumber)
        {
            if (user.IsAvailable)
            {
                sendVoice(user, fromNumber);
            } else
            {
                storeVoiceMessage(user, fromNumber);
            }
        }

        public void contactByTextMessage(User user, String message)
        {
            if (user.IsAvailable)
            {
                sendTextMessageWithSound(user, message);
            }
            else
            {
                sendTextMessageWithoutSound(user, message);
            }
        }
    }
}

using System;

namespace Re_TTSCat.Data
{
    public class UserGift
    {
        public string User;
        public long UserId;
        public string Gift;
        public int Qty;
        public DateTimeOffset TargetTime;

        public UserGift() => TargetTime = DateTimeOffset.Now + TimeSpan.FromSeconds(Vars.CurrentConf.GiftsThrottleDuration);
        public UserGift(string user, long userId, string gift, int qty) : this()
        {
            User = user;
            UserId = userId;
            Gift = gift;
            Qty = qty;
        }

        public bool IsAddable(UserGift gift) => (gift.UserId == UserId) && (gift.Gift == Gift);
    }
}

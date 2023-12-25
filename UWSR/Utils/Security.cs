namespace UWSR.Utils
{
    public static class Security
    {
        public static bool CheckIsAdmin(HttpContext context)
        {
            var check = context.Session.Get("isAdmin");
            if (check == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}

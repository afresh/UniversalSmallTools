namespace UST.Utility
{
    /// <summary>
    /// 正则表达式
    /// </summary>
    public static class RegExpr
    {
        /// <summary>
        /// 域名
        /// </summary>
        public const string Host = @"[a-zA-Z0-9][-a-zA-Z0-9]{0,62}(/.[a-zA-Z0-9][-a-zA-Z0-9]{0,62})+/.?";
        /// <summary>
        /// win10激活码
        /// </summary>
        public const string Win10ActivationCode = @"^[a-zA-Z0-9]{5}(-[-a-zA-Z0-9]{5}){4}$";
    }
}

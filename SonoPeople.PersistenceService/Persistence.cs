namespace PersistenceService
{
    public class Persistence
    {
        private static readonly Persistence _instance = new Persistence();
        private static bool _isInitialized;
        private static ProviderCollection _providers;
        private static PersistenceProvider _provider;

        static Persistence()
        {
            _instance.Initialize();
        }

        public static Persistence Instance
        {
            get { return _instance; }
        }

        /// <summary>
        ///     Returns a list of all configured persistence providers.
        /// </summary>
        public ProviderCollection Providers
        {
            get { return _providers; }
        }

        /// <summary>
        ///     Returns the active Persistence provider configured.
        /// </summary>
        public PersistenceProvider Provider
        {
            get { return _provider; }
        }

        private void Initialize()
        {
            if (!_isInitialized)
            {
                _provider = _providers[Config.DefaultProvider] as PersistenceProvider;
                _isInitialized = true;
            }
        }
    }
}

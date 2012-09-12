using ConeBrewing.Data.Finders;
using StructureMap;
namespace ConeBrewing.MVC.DependencyResolution {
    public static class IoC {
        public static IContainer Initialize() {
            ObjectFactory.Initialize(x =>
                        {
                            x.Scan(scan =>
                                    {
                                        scan.TheCallingAssembly();
                                        scan.WithDefaultConventions();
                                    });
                            x.For<IBeerFinder>().Use<InMemoryBeerFinder>();
                        });
            return ObjectFactory.Container;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Practices.Unity;
using WinForms.Demo.Gui.Views;
using Dinjo.Logs.Contracts;
using Dinjo.Logs;
using WinForms.Demo.Core.Repositories;
using WinForms.Demo.Core.Services;
using WinForms.Demo.Infrastructure.Repositories;
using WinForms.Demo.Infrastructure.Services;
using WinForms.Demo.Gui.Core.Contracts.Presenters;
using WinForms.Demo.Gui.Core.Contracts.Views;
using WinForms.Demo.Gui.Presenters;

namespace WinForms.Demo.Gui.DI
{
    public class Injector
    {
        private static UnityContainer container = null;

        public static UnityContainer Container
        {
            get
            {
                if (container == null)
                {

                    container = new UnityContainer();

                    lock (container)
                    {
                        container
                        .RegisterType<ILogger, NLogLogger>(
                            new InjectionConstructor("demo-todos"))

                        .RegisterType<ITodosRepository, EFTodosRepository>(
                            new InjectionConstructor(
                                new ResolvedParameter<ILogger>()))
                        .RegisterType<ITeamMembersRepository, EFTeamMembersRepository>(
                            new InjectionConstructor(
                                new ResolvedParameter<ILogger>()))
                        .RegisterType<IRolesRepository, EFRolesRepository>(
                            new InjectionConstructor(
                                new ResolvedParameter<ILogger>()))

                        .RegisterType<ITodosManager, TodosManager>(
                            new InjectionConstructor(
                                new ResolvedParameter<ITodosRepository>(),
                                new ResolvedParameter<ILogger>()))
                        .RegisterType<ITeamMembersManager, TeamMembersManager>(
                            new InjectionConstructor(
                                new ResolvedParameter<ITeamMembersRepository>(),
                                new ResolvedParameter<ILogger>()))
                        .RegisterType<IRolesManager, RolesManager>(
                            new InjectionConstructor(
                                new ResolvedParameter<IRolesRepository>(),
                                new ResolvedParameter<ILogger>()))

                        .RegisterType<IPlatformPresenter, PlatformPresenter>()
                        .RegisterType<IPlatformView, PlatformWF>(
                            new InjectionConstructor(
                                new ResolvedParameter<IPlatformPresenter>(),
                                new ResolvedParameter<ITeamMemberListView>()))
                        .RegisterType<ITeamMemberListPresenter, TeamMemberListPresenter>(
                            new InjectionConstructor(
                                new ResolvedParameter<ITeamMembersManager>()))
                        .RegisterType<ITeamMemberListView, TeamMemberListWF>(
                            new InjectionConstructor(
                                new ResolvedParameter<ITeamMemberListPresenter>(),
                                new ResolvedParameter<ITeamMemberDetailsView>()))
                        .RegisterType<ITeamMemberDetailsPresenter, TeamMemberDetailsPresenter>(
                            new InjectionConstructor(
                                new ResolvedParameter<ITeamMembersManager>()))
                        .RegisterType<ITeamMemberDetailsView, TeamMemberDetailsWF>(
                            new InjectionConstructor(
                                new ResolvedParameter<ITeamMemberDetailsPresenter>()))
                        ;
                    }
                }

                return container;
            }
        }

        public static void UnloadContainer()
        {
            container = null;
        }

    }
}

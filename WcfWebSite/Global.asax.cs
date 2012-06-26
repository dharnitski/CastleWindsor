using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Castle.Windsor;
using Castle.MicroKernel.Registration;
using Castle.Facilities.WcfIntegration;
using System.ServiceModel;
using Contract;
using System.Xml;

/// <summary>
/// Summary description for Global
/// </summary>
public partial class Global : System.Web.HttpApplication
{

    private static IWindsorContainer container;

    void Application_Start(object sender, EventArgs e)
    {
        container = new WindsorContainer();

        container.Register(Component.For<IFileDownloadService>()
       .ImplementedBy<FileDownloadService>()
       .Named("FileDownloadService")
       .AsWcfService(new DefaultServiceModel()
       .AddEndpoints(WcfEndpoint
              .BoundTo(new BasicHttpBinding
              {
                  MaxReceivedMessageSize = 2147483647,
                  MaxBufferSize = 2147483647,
                  MaxBufferPoolSize = 2147483647,
                  TransferMode = TransferMode.Streamed,
                  MessageEncoding = WSMessageEncoding.Mtom,
                  ReaderQuotas = new XmlDictionaryReaderQuotas
                  {
                      MaxDepth = 2147483647,
                      MaxArrayLength = 2147483647,
                      MaxStringContentLength = 2147483647,
                      MaxNameTableCharCount = 2147483647,
                      MaxBytesPerRead = 2147483647
                  }
              }))
              .Hosted()
              .PublishMetadata())
      .LifeStyle.PerWcfOperation());

        container.AddFacility<WcfFacility>();
    }

    void Application_End(object sender, EventArgs e)
    {
        container.Dispose();

    }

    #region IContainerAccessor Members
    public IWindsorContainer Container
    {
        get { return container; }
    }
    #endregion

    void Application_Error(object sender, EventArgs e)
    {
        // Code that runs when an unhandled error occurs

    }

    void Session_Start(object sender, EventArgs e)
    {
        // Code that runs when a new session is started

    }

    void Session_End(object sender, EventArgs e)
    {
        // Code that runs when a session ends.
        // Note: The Session_End event is raised only when the sessionstate mode
        // is set to InProc in the Web.config file. If session mode is set to StateServer
        // or SQLServer, the event is not raised.

    }
}
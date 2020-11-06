using QBFC13Lib;

namespace SA2QBookSvc.DataAccessQuickBooks {
    public class Repository {
        public QBSessionManager OpenConnection() {
            /* 11/6/20 8:42 Pwd: Duk3Ha$ */
            QBSessionManager qbData = new QBSessionManager();
            qbData.OpenConnection("","SA2QBook");
            //qbData.OpenConnection(AppID,AppName)
            //qbData.BeginSession(qbFile,openMode)
            //qbData.BeginSession("Crown Meat Prototype 2_E2",ENOpenMode.omDontCare);
            qbData.BeginSession("",ENOpenMode.omDontCare);
            return qbData;
        }
    }
}

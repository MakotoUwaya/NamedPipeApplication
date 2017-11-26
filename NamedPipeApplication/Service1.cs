using System;
using WcfServiceLibrary1;

namespace NamedPipeApplication
{
    // メモ: [リファクター] メニューの [名前の変更] コマンドを使用すると、コードと config ファイルの両方で同時にクラス名 "Service1" を変更できます。
    public class Service1 : IService1
    {
        public void GetData(int value)
        {
            Console.WriteLine("You entered: {0}", value);
        }

        public void GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            Console.WriteLine("BoolValue:{0}, StringValue:{1}", composite.BoolValue, composite.StringValue);
        }

        public void RenderStart()
        {

        }
    }
}

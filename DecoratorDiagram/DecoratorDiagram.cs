using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorDiagram
{
   
    public interface DataSource
    {
        public void writeData(string data);

        public void readData(string data);
    }

    public class FileDataSource : DataSource
    {


        private string filename;

        public FileDataSource(string filename)
        {
            this.filename = filename;
        }

        public void readData(string data)
        {
            throw new NotImplementedException();
        }

        public void writeData(string data)
        {
            throw new NotImplementedException();
        }
    }


    public abstract class DataSourceDecorator:DataSource
    {
        private DataSource wrappee { get; set; }

        public DataSourceDecorator(DataSource wrappee)
        {

        }

        public virtual void   writeData(string data)
        {
           
        }

        public virtual void readData(string data)
        {
           
        }



    }

    public class EncryptionDecorator:DataSourceDecorator
    {

        public EncryptionDecorator(DataSource wrappee) : base(wrappee)
        {

        }

        public override void writeData(string data)
        {
            Console.WriteLine("WriteData");
        }

        public override void readData(string data)
        {
            Console.WriteLine("readData");
        }
    }

    public class CompressionDecorator:DataSourceDecorator
    {

      
        public CompressionDecorator(DataSource wrappee):base(wrappee)
        {

        }


        public override void writeData(string data)
        {
            Console.WriteLine("WriteData");
        }

        public override void readData(string data)
        {
            Console.WriteLine("readData");
        }

    }


}

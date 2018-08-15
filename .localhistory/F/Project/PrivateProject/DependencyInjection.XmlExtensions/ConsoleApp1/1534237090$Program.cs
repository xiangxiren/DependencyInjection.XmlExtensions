using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var xml = @"
                <settings>
                    <Data.Setting>
                        <DefaultConnection>
                            <Connection.String>Test.Connection.String</Connection.String>
                            <Provider>SqlClient</Provider>
                        </DefaultConnection>
                        <Inventory>
                            <ConnectionString>AnotherTestConnectionString</ConnectionString>
                            <Provider>MySql</Provider>
                        </Inventory>
                    </Data.Setting>
                </settings>";

            var xmlDocument = new XmlDocument();
            xmlDocument.LoadXml(xml);

            Console.WriteLine("Hello World!");
        }
    }
}

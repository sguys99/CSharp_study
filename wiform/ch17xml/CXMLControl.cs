using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Xml;//추가

namespace ch17xml
{
    class CXMLControl
    {
        public static string _TEXT_DATA = "TEXT_DATA"; // 잘 안바뀌는 값을 static으로 정의
        public static string _CBOX_DATA = "CBOX_DATA"; // 잘 안바뀌는 값을 static으로 정의
        public static string _NUMBER_DATA = "NUMBER_DATA"; // 잘 안바뀌는 값을 static으로 정의

        public Dictionary<string, string> fXML_Reader(string strXMLPath) // xml 파일 경로를 입력하면 그 파일을 읽어서 dictionary로 리턴하는 함수
        {
            Dictionary<string, string> DXMLConfig = new Dictionary<string, string>(); // 딕셔너리 생성

            using (XmlReader rd = XmlReader.Create(strXMLPath)) //using을 벗어나면 내부의 내용이 해제됨. 메모리 관리가 쉽다.
            {
                while (rd.Read())//xml노드를 계속 읽어들임. 마지막까지 내려가면서
                {
                    if (rd.IsStartElement())//시작부분인지
                    {
                        if (rd.Name.Equals("SETTING"))
                        {
                            string strID = rd["ID"];
                            rd.Read(); // 저장하고 하위노드 읽기

                            string strText = rd.ReadElementContentAsString(_TEXT_DATA, "");// "TEXT_DATA" 항목을 string으로 받겠다., 두번째 인자는 namespace 이름
                            DXMLConfig.Add(_TEXT_DATA, strText); //XML에 저장

                            string strCBox = rd.ReadElementContentAsString(_CBOX_DATA, "");// "CBOX_DATA" 항목을 string으로 받겠다.
                            DXMLConfig.Add(_CBOX_DATA, strCBox); //XML에 저장

                            string strNumber = rd.ReadElementContentAsString(_NUMBER_DATA, "");// "NUMBER_DATA" 항목을 string으로 받겠다.
                            DXMLConfig.Add(_NUMBER_DATA, strNumber); //XML에 저장
                        }
                    }
                }
            }


                return DXMLConfig;
        }

        public void fXML_Writer(String strXMLPath, Dictionary<string, string> DXMLConfig)
        {
            using (XmlWriter wr = XmlWriter.Create(strXMLPath))
            {
                wr.WriteStartDocument();

                wr.WriteStartElement("SETTING");
                wr.WriteAttributeString("ID", "0001"); //attribute 쓰기

                wr.WriteElementString(_TEXT_DATA, DXMLConfig[_TEXT_DATA]);
                wr.WriteElementString(_CBOX_DATA, DXMLConfig[_CBOX_DATA]);
                wr.WriteElementString(_NUMBER_DATA, DXMLConfig[_NUMBER_DATA]);

                wr.WriteEndElement();
                wr.WriteEndDocument();
            }
        }
    }
}

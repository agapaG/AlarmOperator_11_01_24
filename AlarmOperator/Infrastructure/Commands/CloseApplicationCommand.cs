using System;
using System.Text;
using System.Windows;
using System.Net.Sockets;
using System.Configuration;

using AlarmOperator.Infrastructure.Commands.Base;

namespace AlarmOperator.Infrastructure.Commands
{
	internal class CloseApplicationCommand : BaseCommand
	{
		public override bool CanExecute(object parameter) => true;

		public override void Execute(object parameter)
		{
			string IPAddr = ConfigurationManager.AppSettings["ip"];

			TcpClient tcpClient = new TcpClient();

			try
			{
				tcpClient.Connect(System.Net.IPAddress.Parse(IPAddr), 8080);
				var stream = tcpClient.GetStream();

				byte[] Request = _createRequest_Little_Endian(0x0c00, 0xddcf);
				stream.Write(Request, 0, Request.Length);

				Request = Encoding.UTF8.GetBytes(App.NameOperator);
				// определяем размер данных
				byte[] size = BitConverter.GetBytes(Request.Length);
				// отправляем размер данных
				stream.Write(size, 0, size.Length);
				// отправляем данные
				stream.Write(Request, 0, Request.Length);

			}
			catch (Exception ex)
			{
				if (!tcpClient.Connected)
				{
					MessageBox.Show($"Отсутствует подключение к серверу {ex.Message}");
				}
			}
			finally
			{
				tcpClient.Close();
			}

			App.Current.Shutdown();
		}

		private byte[] _createRequest_Little_Endian(ushort idReq, ushort idS)
		{
			byte[] Request = new byte[32];
			//Формирую ID запроса
			Request[0] = (byte)idReq;
			Request[1] = (byte)(idReq >> 8);

			//Формирую ID системы (сервер ИВС)
			Request[2] = (byte)idS;
			Request[3] = (byte)(idS >> 8);

			//Резерв + признак первого запроса
			Request[4] = 0b1;

			Request[31] = (byte)'\n';

			return Request;
		}

	}

}

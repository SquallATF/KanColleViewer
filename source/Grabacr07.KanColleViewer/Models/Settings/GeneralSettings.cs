using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using MetroTrilithon.Serialization;

namespace Grabacr07.KanColleViewer.Models.Settings
{
	public static class GeneralSettings
	{
		/// <summary>
		/// �J���`���ݒ���擾���܂��B
		/// </summary>
		public static SerializableProperty<string> Culture { get; }
			= new SerializableProperty<string>(GetKey(), Providers.Roaming) { AutoSave = true };

		/// <summary>
		/// �A�v���P�[�V�������v���L�V ���[�h (�u���E�U�[��\�������A�v���L�V�Ƃ��Ă̂ݎg�p���郂�[�h) �œ��삷�邩�ǂ����������ݒ�l���擾���܂��B
		/// </summary>
		public static SerializableProperty<bool> IsProxyMode { get; }
			= new SerializableProperty<bool>(GetKey(), Providers.Roaming, false);

		/// <summary>
		/// �A�v���P�[�V�����I�����̊m�F����������ݒ�l���擾���܂��B
		/// </summary>
		public static SerializableProperty<ExitConfirmationType> ExitConfirmationType { get; }
			= new SerializableProperty<ExitConfirmationType>(GetKey(), Providers.Roaming, Models.ExitConfirmationType.None) { AutoSave = true };

		/// <summary>
		/// �u���E�U�[�̊g�勾�������ݒ�l���擾���܂��B
		/// </summary>
		public static SerializableProperty<double> BrowserZoomFactor { get; }
			= new SerializableProperty<double>(GetKey(), Providers.Local, 1.0);


		private static string GetKey([CallerMemberName] string propertyName = "")
		{
			return nameof(GeneralSettings) + "." + propertyName;
		}
	}
}

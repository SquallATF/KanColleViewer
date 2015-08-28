using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using MetroTrilithon.Serialization;

namespace Grabacr07.KanColleViewer.Models.Settings
{
	/// <summary>
	/// �X�N���[���V���b�g�Ɋ֘A����ݒ��\���ÓI�v���p�e�B�����J���܂��B
	/// </summary>
	public static class ScreenshotSettings
	{
		/// <summary>
		/// �X�N���[���V���b�g�̕ۑ���t�H���_�[��\���ݒ�l���擾���܂��B
		/// </summary>
		public static SerializableProperty<string> Destination { get; }
			= new SerializableProperty<string>(GetKey(), Providers.Local, Environment.GetFolderPath(Environment.SpecialFolder.MyPictures));

		/// <summary>
		/// �X�N���[���V���b�g�̃t�@�C������\���ݒ�l���擾���܂��B
		/// </summary>
		public static SerializableProperty<string> Filename { get; }
			= new SerializableProperty<string>(GetKey(), Providers.Local, "KanColle-{0:d04}.png");

		/// <summary>
		/// �X�N���[���V���b�g�̃C���[�W�`����\���ݒ�l���擾���܂��B
		/// </summary>
		public static SerializableProperty<SupportedImageFormat> Format { get; }
			= new SerializableProperty<SupportedImageFormat>(GetKey(), Providers.Local, SupportedImageFormat.Png);


		private static string GetKey([CallerMemberName] string propertyName = "")
		{
			return nameof(ScreenshotSettings) + "." + propertyName;
		}
	}
}

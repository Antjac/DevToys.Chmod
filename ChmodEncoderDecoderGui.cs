using Chmod;
using DevToys.Api;
using System.ComponentModel.Composition;
using static DevToys.Api.GUI;

namespace Chmod;

[Export(typeof(IGuiTool))]
[Name("ChmodEncoderDecoder")]                                                        
[ToolDisplayInformation(
	IconFontName = "FluentSystemIcons",                                       
	IconGlyph = '\uE670',                                                     
	GroupName = PredefinedCommonToolGroupNames.EncodersDecoders,             
	ResourceManagerAssemblyIdentifier = nameof(MyResourceAssemblyIdentifier),
	ResourceManagerBaseName = "Chmod.ChmodEncoderDecoder",
	ShortDisplayTitleResourceName = nameof(ChmodEncoderDecoder.ShortDisplayTitle),
	LongDisplayTitleResourceName = nameof(ChmodEncoderDecoder.LongDisplayTitle),
	DescriptionResourceName = nameof(ChmodEncoderDecoder.Description),
	AccessibleNameResourceName = nameof(ChmodEncoderDecoder.AccessibleName))]
internal sealed class ChmodEncoderDecoderGui : IGuiTool
{
	public UIToolView View => new(Label().Style(UILabelStyle.BodyStrong).Text(ChmodEncoderDecoder.HelloWorldLabel));

	public void OnDataReceived(string dataTypeName, object? parsedData)
	{
		throw new NotImplementedException();
	}
}
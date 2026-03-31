using System.Collections.ObjectModel;
using xFlow.Models;

namespace xFlow.ViewModels;

public partial class MainWindowViewModel : ViewModelBase
{
    public string Greeting { get; } = "Welcome to Avalonia!";
    public ObservableCollection<RowData> YourDataList { get; set; }
    
    public MainWindowViewModel()
    {
        // 2. Khởi tạo danh sách và thêm dữ liệu mẫu để bảng không bị trống
        YourDataList = new ObservableCollection<RowData>
        {
            new RowData { Column1Property = "Dòng 1", Column2Property = "Dữ liệu A", Column3Property = "Hoàn thành" },
            new RowData { Column1Property = "Dòng 2", Column2Property = "Dữ liệu B", Column3Property = "Đang chờ" },
            new RowData { Column1Property = "Dòng 3", Column2Property = "Dữ liệu C", Column3Property = "Lỗi" },
            new RowData { Column1Property = "Dòng 4", Column2Property = "Dữ liệu D", Column3Property = "Hoàn thành" }
        };
    }
}
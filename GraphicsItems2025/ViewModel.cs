using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;

namespace GraphicsItems2025
{
    public class ViewModel : INotifyPropertyChanged, INotifyCollectionChanged
    {
        private List<Vertex> _vertexes = new ();
        private List<Edge> _edges = new ();
        public List<Vertex> Vertexes{
            get => _vertexes;
        }

        public List<Edge> Edges
        {
            get => _edges;
        }

        public ViewModel()
        {
            _vertexes.Add(new Vertex() { Margin = new Thickness(10, 10, 0, 0), BgColor = Colors.YellowGreen });
            _vertexes.Add(new Vertex() { Margin = new Thickness(70, 10, 0, 0), BgColor = Colors.Green });
            _vertexes.Add(new Vertex() { Margin = new Thickness(130, 10, 0, 0), BgColor = Colors.Aqua });
            _vertexes.Add(new Vertex() { Margin = new Thickness(40, 70, 0, 0), BgColor = Color.FromRgb(255, 0, 0) });
            _vertexes.Add(new Vertex() { Margin = new Thickness(100, 70, 0, 0), BgColor = Color.FromArgb(100, 0, 0, 255) });
            _edges.Add(new Edge());
            _edges.Add(new Edge());
            _edges.Add(new Edge());
        }

        public event PropertyChangedEventHandler? PropertyChanged;
        public event NotifyCollectionChangedEventHandler? CollectionChanged;
    }
}

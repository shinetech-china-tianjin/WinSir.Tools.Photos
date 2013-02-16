using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WinSir.Tools.Photos.Motivations
{
    public class MotivationContainer : IMotivation, IList<IMotivation>
    {
        private IList<IMotivation> _motivations;

        public MotivationContainer() {
            _motivations = new List<IMotivation>();
        }

        public void Execute() {
            foreach (var motivation in _motivations) {
                motivation.Execute();
            }
        }

        public int IndexOf(IMotivation item) {
            return _motivations.IndexOf(item);
        }

        public void Insert(int index, IMotivation item) {
            _motivations.Insert(index, item);
        }

        public void RemoveAt(int index) {
            _motivations.RemoveAt(index);
        }

        public IMotivation this[int index] {
            get { return _motivations[index]; }
            set { _motivations[index] = value; }
        }

        public void Add(IMotivation item) {
            _motivations.Add(item);
        }

        public void Clear() {
            _motivations.Clear();
        }

        public bool Contains(IMotivation item) {
            return _motivations.Contains(item);
        }

        public void CopyTo(IMotivation[] array, int arrayIndex) {
            _motivations.CopyTo(array, arrayIndex);
        }

        public int Count {
            get { return _motivations.Count; }
        }

        public bool IsReadOnly {
            get { return _motivations.IsReadOnly; }
        }

        public bool Remove(IMotivation item) {
            return _motivations.Remove(item);
        }

        public IEnumerator<IMotivation> GetEnumerator() {
            return _motivations.GetEnumerator();
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() {
            return GetEnumerator();
        }
    }
}

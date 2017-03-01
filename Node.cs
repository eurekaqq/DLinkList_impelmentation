using EX = System.Exception;

namespace node {
    class Node<T> {
        T _data;
        Node<T> _front = null;
        Node<T> _back = null;
        public T data => _data;
        public Node<T> front {
            get {
                return _front;
            }
            set {
                _front = value;
            }
        }
        public Node<T> back {
            get {
                return _back;
            }
            set {
                _back = value;
            }
        }
        
        public Node():this(default(T)) {
            
        }

        public Node(T data) {
            _data = data;
        }
    }
}

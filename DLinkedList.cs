using node;
using Console = System.Console;


namespace DLinkedList {
    class DLinkedList<T>{
        Node<T> _first;
        Node<T> _rear;
        int _lenght = 0;
        public Node<T> first => _first;
        public Node<T> rear => _rear;
        public int length => _lenght;


        public DLinkedList(T data) {
            add(data);
        }

        public void add(T data) {
            var temp = new Node<T>(data);
            if(_first == null) {
                _first = temp;
                _rear = temp;
                temp.front = _rear;
                temp.back = _first;
            }
            else {
                temp.front = _rear;
                temp.back = _first;
                _rear.back = temp;
                _first.front = temp;
                _rear = temp;
            }
            ++_lenght;
        }

        public void remove(T data) {
            var iter = first;
            for(int i = 0; i < length; ++i) {
                if (iter.data.Equals(data)) {
                    iter.front.back = iter.back;
                    iter.back.front = iter.front;
                    --_lenght;
                    Console.WriteLine(data + " is removed");
                    return;
                }
                else {
                    iter = iter.back;
                }
            }
            Console.WriteLine(data + " is not fround");
        }
    }
}

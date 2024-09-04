using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace MyLinkedList‏
{
    internal class Node
    {
        internal int data;
        internal Node? next;
        public Node(int d)
        {
            data = d;
            next = null;
        }
    }

    internal class LinkedList
    {

        private Node? _head;

        // O(1)
        public LinkedList()
        {
            _head = null;
        }

        // O(1)
        public LinkedList(int data)
        {
            Node newNode = new(data);
            _head = newNode;
        }

        // O(n)
        public void Add(int data)
        {
            Node newNode = new(data);
            if (_head == null)
            {
                _head = newNode;
                return;
            }
            var temp = _head;
            while (temp.next != null)
            {
                temp = temp.next;
            }
            temp.next = newNode;
        }

        // O(n)
        public string Display()
        {
            if (_head == null) return "";
            Node? tamp = _head;
            string repr = $"{tamp.data}";
            while (tamp.next != null)
            {
                tamp = tamp.next;
                repr += $" -> {tamp.data}";
            }
            return $"{repr}";
        }

        // O(n)
        public int Length()
        {
            if (_head == null) return 0;
            Node? tamp = _head;
            int len = 1;
            while (tamp.next != null)
            {
                tamp = tamp.next;
                len++;
            }
            return len;
        }

        // O(n)
        public void RemoveValue(int data)
        {
            if (_head == null) return;

            if (_head.data == data)
            {
                _head = _head.next;
                return;
            }

            Node? temp = _head;

            while (temp.next != null)
            {
                if (temp.next.data == data)
                {
                    temp.next = temp.next.next;
                    return;
                }
                temp = temp.next;
            }
        }

        // O(n)
        public void RemoveAllValues(int data)
        {
            if (_head == null) return;

            while (_head != null && _head.data == data)
                _head = _head.next;

            Node? temp = _head;

            while (temp != null && temp.next != null)
            {
                if (temp.next.data == data)
                    temp.next = temp.next.next;
                else
                    temp = temp.next;
            }
        }

        // O(1)
        public void RemoveIndex(int index)
        {
            if (index >= Length())
                throw new NotImplementedException($"index {index} Does not exist in the Linked List");
            if (_head == null) return;
            var tamp = _head;
            for (int i = 0; i < index - 1; i++)
            {
                tamp = tamp!.next;
            }
            if (tamp!.next!.next == null)
            {
                tamp.next = null;
                return;
            }
            tamp.next = tamp.next!.next;
            tamp = null;
        }

        // O(n)
        public int Find(int data)
        {
            if (_head == null) return -1;
            Node? tamp = _head;
            int index = 0;
            while (tamp.next != null)
            {
                if(tamp.data == data)
                    return index;
                index++;
                tamp = tamp!.next;
            }
            if (tamp.data == data)
                return index;
            return -1;
        }

        // O(1)
        public int Get(int index)
        {
            if (index >= Length())
                return -1;
            if (_head == null)
                return -1;
            var tamp = _head;
            for (int i = 0; i < index; i++)
            {
                tamp = tamp!.next;
            }
            return tamp!.data;
        }
    }
}

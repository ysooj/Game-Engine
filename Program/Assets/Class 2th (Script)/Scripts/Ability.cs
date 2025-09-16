using UnityEngine;

// ����ȭ ������ Ŭ�������� Unity�� �˸��� Ư��(attribute)
// �̷��� �ϸ� Unity �ν����Ϳ��� �� Ŭ������ �ʵ带 �� �� ����
[System.Serializable]
public class Ability
{
    // [SerializeField] : �ʵ尡 private�̴��� Unity �ν����Ϳ� ����ǵ��� ��
    // ��, �ڵ� �󿡼��� �ܺο��� ������ �� ������, �����Ϳ����� ���� �����ϰų� Ȯ���� �� ����
    [SerializeField] int strength;
    [SerializeField] int intelligence;
    [SerializeField] int dexterity;
    [SerializeField] int wisdom;
}
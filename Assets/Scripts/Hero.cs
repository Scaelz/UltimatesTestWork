using UnityEngine;

[RequireComponent(typeof(Animator))]
public class Hero : MonoBehaviour
{
    Animator _animator;
    ParticleSystem _ps;
    public void Initialize(ParticleSystem particleSystem)
    {
        _ps = particleSystem;
    }

    private void Awake()
    {
        _animator = GetComponent<Animator>();
    }

    public void Cast()
    {
        _animator.SetTrigger("Cast");
        _ps.Play();
    }
}

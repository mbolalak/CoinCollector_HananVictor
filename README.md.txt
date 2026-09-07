# Project PTS Pemrograman Game Dev

## Identitas Siswa
* **Nama**: Hanan Victor
* **Kelas**: 11 PPLG 3
* **Project Name**: CoinCollector_HananVictor


## Fitur & Ketentuan PTS
1. **GameManager**
2. **PlayerMovement**
3. **Penerapan OOP**
   - **Abstraction**: Interface `IDamageable.cs`.
   - **Inheritance**: `Enemy.cs` diturunkan ke `blyatman.cs`.
   - **Polymorphism**: Override fungsi `Serang()` pada class `blyatman.cs`.
4. **State Machine**: Enum `StateZombie.cs` (IDLE, PATROL, CHASE, ATTACK).
5. **Delegate & Event**:
   - `BelajarDelegate.cs`:
   - `PemancarEvent.cs`: Memancarkan event tombol Spasi.
   - `PenerimaEvent.cs`: Menerima event dan merespon pada Player.
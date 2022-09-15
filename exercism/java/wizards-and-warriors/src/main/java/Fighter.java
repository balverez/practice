abstract class Fighter {

    boolean isVulnerable() {
        throw new UnsupportedOperationException("Please provide implementation for this method");
    }

    abstract int damagePoints(Fighter fighter);

}

class Warrior extends Fighter {
    private final int CRITICAL_DAMAGE = 10;
    private final int BASE_DAMAGE = 6;

    @Override
    public String toString() {
        return String.format("Fighter is a %s", getClass().getName());
    }

    @Override
    boolean isVulnerable() { return false; }

    @Override
    int damagePoints(Fighter wizard) {
        return wizard.isVulnerable() ? CRITICAL_DAMAGE : BASE_DAMAGE;
    }
}

class Wizard extends Fighter {
    private final int CRITICAL_DAMAGE = 12;
    private final int BASE_DAMAGE = 3;
    private boolean spellPrepared = false;

    @Override
    public String toString() {
        return String.format("Fighter is a %s", getClass().getName());
    }

    @Override
    boolean isVulnerable() {
        return !spellPrepared;
    }

    @Override
    int damagePoints(Fighter warrior) {
        return spellPrepared ? CRITICAL_DAMAGE : BASE_DAMAGE;
    }

    void prepareSpell() {
        spellPrepared = true;
    }

}

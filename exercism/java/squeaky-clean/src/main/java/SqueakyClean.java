class SqueakyClean {
    static String clean(String identifier) {
        StringBuilder result = new StringBuilder();
        boolean kebabFlag = false;
        for (char c : identifier.toCharArray()) {
            if (c == ' ') {
                result.append('_');
                continue;
            } else if (Character.isISOControl(c)) {
                result.append("CTRL");
                continue;
            } else if (c == '-') {
                kebabFlag = true;
                continue;
            } else if (kebabFlag) {
                kebabFlag = false;
                c = Character.toUpperCase(c);
            }

            if (Character.isLetter(c) && !(c >= 'α' && c <= 'ω')) {
                result.append(c);
            }
        }
        return result.toString();
    }
}

function humanReadable(seconds) {
    let hour;
    let minute;
    let second;
    let time;
    hour = Math.floor(seconds / 3600);
    time = seconds % 3600;

    minute = Math.floor(time / 60);
    time = time % 60;

    second = time;

    return `${('0' + hour).slice(-2)}:${('0' + minute).slice(-2)}:${('0' + second).slice(-2)}`;
}

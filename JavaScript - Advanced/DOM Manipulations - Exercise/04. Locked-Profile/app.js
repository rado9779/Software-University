function lockedProfile() {

    const profiles = document.getElementsByClassName('profile');

    for (const profile of Object.values(profiles)) {

        const lockRadioButton = profile.getElementsByTagName('input')[0];
        const profileButton = profile.getElementsByTagName('button')[0];
        const hiddenFields = profile.getElementsByTagName('div')[0];

        profileButton.addEventListener('click', showProfile);

        function showProfile(e) {

            if (lockRadioButton.checked === false) {

                if (profileButton.textContent === 'Show more') {
                    profileButton.textContent = 'Hide it';
                    hiddenFields.style.display = 'block';
                }
                else {
                    profileButton.textContent = 'Show more';
                    hiddenFields.style.display = 'none';
                }
            }
        }
    }
}
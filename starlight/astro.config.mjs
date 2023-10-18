import { defineConfig } from "astro/config";
import starlight from "@astrojs/starlight";

// https://astro.build/config
export default defineConfig({
    integrations: [
        starlight({
            title: "trueberryless.org",
            social: {
                github: "https://github.com/trueberryless-org",
            },
            logo: {
                src: "./src/assets/logo.png",
                replacesTitle: true,
            },
            sidebar: [
                { label: "Home", link: "/" },
                {
                    label: "Projects",
                    items: [
                        { label: "Mutanuq", link: "/mutanuq" },
                        { label: "TrainIT", link: "/trainit" },
                    ],
                },
            ],
            customCss: ["./src/style.css"],
        }),
    ],
});

<?php

/* @Twig/layout.html.twig */
class __TwigTemplate_0ef46ff3e00be850b375145c4de69a72941605b1b30816a42d1a36aa92bc080f extends Twig_Template
{
    public function __construct(Twig_Environment $env)
    {
        parent::__construct($env);

        $this->parent = false;

        $this->blocks = array(
            'title' => array($this, 'block_title'),
            'head' => array($this, 'block_head'),
            'body' => array($this, 'block_body'),
        );
    }

    protected function doDisplay(array $context, array $blocks = array())
    {
        $__internal_de13e2dadf8fdaa0b650e9911a5d5a0a41290f23bfb8e54e9e67fe67ed05c2a0 = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_de13e2dadf8fdaa0b650e9911a5d5a0a41290f23bfb8e54e9e67fe67ed05c2a0->enter($__internal_de13e2dadf8fdaa0b650e9911a5d5a0a41290f23bfb8e54e9e67fe67ed05c2a0_prof = new Twig_Profiler_Profile($this->getTemplateName(), "template", "@Twig/layout.html.twig"));

        $__internal_6a184f5eb4b67e3ca746be2e41314d77279d249948841ffe3efa8b864d9096c6 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_6a184f5eb4b67e3ca746be2e41314d77279d249948841ffe3efa8b864d9096c6->enter($__internal_6a184f5eb4b67e3ca746be2e41314d77279d249948841ffe3efa8b864d9096c6_prof = new Twig_Profiler_Profile($this->getTemplateName(), "template", "@Twig/layout.html.twig"));

        // line 1
        echo "<!DOCTYPE html>
<html>
    <head>
        <meta charset=\"";
        // line 4
        echo twig_escape_filter($this->env, $this->env->getCharset(), "html", null, true);
        echo "\" />
        <meta name=\"robots\" content=\"noindex,nofollow\" />
        <meta name=\"viewport\" content=\"width=device-width,initial-scale=1\" />
        <title>";
        // line 7
        $this->displayBlock('title', $context, $blocks);
        echo "</title>
        <link rel=\"icon\" type=\"image/png\" href=\"";
        // line 8
        echo twig_include($this->env, $context, "@Twig/images/favicon.png.base64");
        echo "\">
        <style>";
        // line 9
        echo twig_include($this->env, $context, "@Twig/exception.css.twig");
        echo "</style>
        ";
        // line 10
        $this->displayBlock('head', $context, $blocks);
        // line 11
        echo "    </head>
    <body>
        <header>
            <div class=\"container\">
                <h1 class=\"logo\">";
        // line 15
        echo twig_include($this->env, $context, "@Twig/images/symfony-logo.svg");
        echo " Symfony Exception</h1>

                <div class=\"help-link\">
                    <a href=\"https://symfony.com/doc\">
                        <span class=\"icon\">";
        // line 19
        echo twig_include($this->env, $context, "@Twig/images/icon-book.svg");
        echo "</span>
                        <span class=\"hidden-xs-down\">Symfony</span> Docs
                    </a>
                </div>

                <div class=\"help-link\">
                    <a href=\"https://symfony.com/support\">
                        <span class=\"icon\">";
        // line 26
        echo twig_include($this->env, $context, "@Twig/images/icon-support.svg");
        echo "</span>
                        <span class=\"hidden-xs-down\">Symfony</span> Support
                    </a>
                </div>
            </div>
        </header>

        ";
        // line 33
        $this->displayBlock('body', $context, $blocks);
        // line 34
        echo "        ";
        echo twig_include($this->env, $context, "@Twig/base_js.html.twig");
        echo "
    </body>
</html>
";
        
        $__internal_de13e2dadf8fdaa0b650e9911a5d5a0a41290f23bfb8e54e9e67fe67ed05c2a0->leave($__internal_de13e2dadf8fdaa0b650e9911a5d5a0a41290f23bfb8e54e9e67fe67ed05c2a0_prof);

        
        $__internal_6a184f5eb4b67e3ca746be2e41314d77279d249948841ffe3efa8b864d9096c6->leave($__internal_6a184f5eb4b67e3ca746be2e41314d77279d249948841ffe3efa8b864d9096c6_prof);

    }

    // line 7
    public function block_title($context, array $blocks = array())
    {
        $__internal_dffcfd92ce56731af7e56b251917dcefd3c549540b8d5024cab1ecc51b7ad1e6 = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_dffcfd92ce56731af7e56b251917dcefd3c549540b8d5024cab1ecc51b7ad1e6->enter($__internal_dffcfd92ce56731af7e56b251917dcefd3c549540b8d5024cab1ecc51b7ad1e6_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "title"));

        $__internal_e7ce390bb6e8011fc2b2aaaaed5f846089d15b46d9100be1357efae15c02943f = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_e7ce390bb6e8011fc2b2aaaaed5f846089d15b46d9100be1357efae15c02943f->enter($__internal_e7ce390bb6e8011fc2b2aaaaed5f846089d15b46d9100be1357efae15c02943f_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "title"));

        
        $__internal_e7ce390bb6e8011fc2b2aaaaed5f846089d15b46d9100be1357efae15c02943f->leave($__internal_e7ce390bb6e8011fc2b2aaaaed5f846089d15b46d9100be1357efae15c02943f_prof);

        
        $__internal_dffcfd92ce56731af7e56b251917dcefd3c549540b8d5024cab1ecc51b7ad1e6->leave($__internal_dffcfd92ce56731af7e56b251917dcefd3c549540b8d5024cab1ecc51b7ad1e6_prof);

    }

    // line 10
    public function block_head($context, array $blocks = array())
    {
        $__internal_ce8077dcdc3ab9d4d367ad0e841bec4f82485dd85ffdb08a3ee4a481ddeaeb9e = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_ce8077dcdc3ab9d4d367ad0e841bec4f82485dd85ffdb08a3ee4a481ddeaeb9e->enter($__internal_ce8077dcdc3ab9d4d367ad0e841bec4f82485dd85ffdb08a3ee4a481ddeaeb9e_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "head"));

        $__internal_7d55ed881d48225212077f5ff4c42091ac68c5be67b5fa38b948d32c368229c6 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_7d55ed881d48225212077f5ff4c42091ac68c5be67b5fa38b948d32c368229c6->enter($__internal_7d55ed881d48225212077f5ff4c42091ac68c5be67b5fa38b948d32c368229c6_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "head"));

        
        $__internal_7d55ed881d48225212077f5ff4c42091ac68c5be67b5fa38b948d32c368229c6->leave($__internal_7d55ed881d48225212077f5ff4c42091ac68c5be67b5fa38b948d32c368229c6_prof);

        
        $__internal_ce8077dcdc3ab9d4d367ad0e841bec4f82485dd85ffdb08a3ee4a481ddeaeb9e->leave($__internal_ce8077dcdc3ab9d4d367ad0e841bec4f82485dd85ffdb08a3ee4a481ddeaeb9e_prof);

    }

    // line 33
    public function block_body($context, array $blocks = array())
    {
        $__internal_e5769f001ecd206b06713413352f18bacac46e8adf0c4be237c499d449cd58c9 = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_e5769f001ecd206b06713413352f18bacac46e8adf0c4be237c499d449cd58c9->enter($__internal_e5769f001ecd206b06713413352f18bacac46e8adf0c4be237c499d449cd58c9_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "body"));

        $__internal_2aa8f7610b7c21f6be390984df8d20f88dd8f606e4914d83c9da34c468b759ea = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_2aa8f7610b7c21f6be390984df8d20f88dd8f606e4914d83c9da34c468b759ea->enter($__internal_2aa8f7610b7c21f6be390984df8d20f88dd8f606e4914d83c9da34c468b759ea_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "body"));

        
        $__internal_2aa8f7610b7c21f6be390984df8d20f88dd8f606e4914d83c9da34c468b759ea->leave($__internal_2aa8f7610b7c21f6be390984df8d20f88dd8f606e4914d83c9da34c468b759ea_prof);

        
        $__internal_e5769f001ecd206b06713413352f18bacac46e8adf0c4be237c499d449cd58c9->leave($__internal_e5769f001ecd206b06713413352f18bacac46e8adf0c4be237c499d449cd58c9_prof);

    }

    public function getTemplateName()
    {
        return "@Twig/layout.html.twig";
    }

    public function isTraitable()
    {
        return false;
    }

    public function getDebugInfo()
    {
        return array (  137 => 33,  120 => 10,  103 => 7,  88 => 34,  86 => 33,  76 => 26,  66 => 19,  59 => 15,  53 => 11,  51 => 10,  47 => 9,  43 => 8,  39 => 7,  33 => 4,  28 => 1,);
    }

    /** @deprecated since 1.27 (to be removed in 2.0). Use getSourceContext() instead */
    public function getSource()
    {
        @trigger_error('The '.__METHOD__.' method is deprecated since version 1.27 and will be removed in 2.0. Use getSourceContext() instead.', E_USER_DEPRECATED);

        return $this->getSourceContext()->getCode();
    }

    public function getSourceContext()
    {
        return new Twig_Source("<!DOCTYPE html>
<html>
    <head>
        <meta charset=\"{{ _charset }}\" />
        <meta name=\"robots\" content=\"noindex,nofollow\" />
        <meta name=\"viewport\" content=\"width=device-width,initial-scale=1\" />
        <title>{% block title %}{% endblock %}</title>
        <link rel=\"icon\" type=\"image/png\" href=\"{{ include('@Twig/images/favicon.png.base64') }}\">
        <style>{{ include('@Twig/exception.css.twig') }}</style>
        {% block head %}{% endblock %}
    </head>
    <body>
        <header>
            <div class=\"container\">
                <h1 class=\"logo\">{{ include('@Twig/images/symfony-logo.svg') }} Symfony Exception</h1>

                <div class=\"help-link\">
                    <a href=\"https://symfony.com/doc\">
                        <span class=\"icon\">{{ include('@Twig/images/icon-book.svg') }}</span>
                        <span class=\"hidden-xs-down\">Symfony</span> Docs
                    </a>
                </div>

                <div class=\"help-link\">
                    <a href=\"https://symfony.com/support\">
                        <span class=\"icon\">{{ include('@Twig/images/icon-support.svg') }}</span>
                        <span class=\"hidden-xs-down\">Symfony</span> Support
                    </a>
                </div>
            </div>
        </header>

        {% block body %}{% endblock %}
        {{ include('@Twig/base_js.html.twig') }}
    </body>
</html>
", "@Twig/layout.html.twig", "D:\\PHP Skeleton\\vendor\\symfony\\symfony\\src\\Symfony\\Bundle\\TwigBundle\\Resources\\views\\layout.html.twig");
    }
}
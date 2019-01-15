<?php

/* base.html.twig */
class __TwigTemplate_93e2499d03c6402ea1e3906495568257ed0120721f7f5badb0e11600e82927c5 extends Twig_Template
{
    public function __construct(Twig_Environment $env)
    {
        parent::__construct($env);

        $this->parent = false;

        $this->blocks = array(
            'title' => array($this, 'block_title'),
            'stylesheets' => array($this, 'block_stylesheets'),
            'body_id' => array($this, 'block_body_id'),
            'body' => array($this, 'block_body'),
            'main' => array($this, 'block_main'),
        );
    }

    protected function doDisplay(array $context, array $blocks = array())
    {
        $__internal_f0918d593277ba4acd082bf700a438a3072da8c2782b131b2657c1c667cc4896 = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_f0918d593277ba4acd082bf700a438a3072da8c2782b131b2657c1c667cc4896->enter($__internal_f0918d593277ba4acd082bf700a438a3072da8c2782b131b2657c1c667cc4896_prof = new Twig_Profiler_Profile($this->getTemplateName(), "template", "base.html.twig"));

        $__internal_72a1073b39f9d766873be3b405f7c834062287b1de30bdd6cbb9edca17dbfa55 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_72a1073b39f9d766873be3b405f7c834062287b1de30bdd6cbb9edca17dbfa55->enter($__internal_72a1073b39f9d766873be3b405f7c834062287b1de30bdd6cbb9edca17dbfa55_prof = new Twig_Profiler_Profile($this->getTemplateName(), "template", "base.html.twig"));

        // line 6
        echo "<!DOCTYPE html>
<html lang=\"en-US\">
<head>
    <meta charset=\"UTF-8\"/>
    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1\"/>
    <title>";
        // line 11
        $this->displayBlock('title', $context, $blocks);
        echo "</title>
    ";
        // line 12
        $this->displayBlock('stylesheets', $context, $blocks);
        // line 17
        echo "    <link rel=\"icon\" type=\"image/x-icon\" href=\"";
        echo twig_escape_filter($this->env, $this->env->getExtension('Symfony\Bridge\Twig\Extension\AssetExtension')->getAssetUrl("favicon.ico"), "html", null, true);
        echo "\"/>
</head>

<body id=\"";
        // line 20
        $this->displayBlock('body_id', $context, $blocks);
        echo "\">
";
        // line 21
        $this->displayBlock('body', $context, $blocks);
        // line 24
        echo "</body>
</html>
";
        
        $__internal_f0918d593277ba4acd082bf700a438a3072da8c2782b131b2657c1c667cc4896->leave($__internal_f0918d593277ba4acd082bf700a438a3072da8c2782b131b2657c1c667cc4896_prof);

        
        $__internal_72a1073b39f9d766873be3b405f7c834062287b1de30bdd6cbb9edca17dbfa55->leave($__internal_72a1073b39f9d766873be3b405f7c834062287b1de30bdd6cbb9edca17dbfa55_prof);

    }

    // line 11
    public function block_title($context, array $blocks = array())
    {
        $__internal_81d65fe12fc83ffd3a982b83c0c7e642012c9560550ff38e8e5f65522e65acab = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_81d65fe12fc83ffd3a982b83c0c7e642012c9560550ff38e8e5f65522e65acab->enter($__internal_81d65fe12fc83ffd3a982b83c0c7e642012c9560550ff38e8e5f65522e65acab_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "title"));

        $__internal_70fca59afeadb6f0316b27c596d79318e1bb84ff56b8a6f45cb5b61f577847e0 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_70fca59afeadb6f0316b27c596d79318e1bb84ff56b8a6f45cb5b61f577847e0->enter($__internal_70fca59afeadb6f0316b27c596d79318e1bb84ff56b8a6f45cb5b61f577847e0_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "title"));

        echo "Anime List";
        
        $__internal_70fca59afeadb6f0316b27c596d79318e1bb84ff56b8a6f45cb5b61f577847e0->leave($__internal_70fca59afeadb6f0316b27c596d79318e1bb84ff56b8a6f45cb5b61f577847e0_prof);

        
        $__internal_81d65fe12fc83ffd3a982b83c0c7e642012c9560550ff38e8e5f65522e65acab->leave($__internal_81d65fe12fc83ffd3a982b83c0c7e642012c9560550ff38e8e5f65522e65acab_prof);

    }

    // line 12
    public function block_stylesheets($context, array $blocks = array())
    {
        $__internal_c41952538ba01d27b9e32c8b5f66f1b5e23418a31b21da2d049a9189c8fc9c02 = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_c41952538ba01d27b9e32c8b5f66f1b5e23418a31b21da2d049a9189c8fc9c02->enter($__internal_c41952538ba01d27b9e32c8b5f66f1b5e23418a31b21da2d049a9189c8fc9c02_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "stylesheets"));

        $__internal_0765c70447bd69f9422f5559cf54261edb2da6f417cb43915e88ec8f84486fb6 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_0765c70447bd69f9422f5559cf54261edb2da6f417cb43915e88ec8f84486fb6->enter($__internal_0765c70447bd69f9422f5559cf54261edb2da6f417cb43915e88ec8f84486fb6_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "stylesheets"));

        // line 13
        echo "        ";
        // line 14
        echo "        ";
        // line 15
        echo "        <link rel=\"stylesheet\" href=\"";
        echo twig_escape_filter($this->env, $this->env->getExtension('Symfony\Bridge\Twig\Extension\AssetExtension')->getAssetUrl("css/style.css"), "html", null, true);
        echo "\">
    ";
        
        $__internal_0765c70447bd69f9422f5559cf54261edb2da6f417cb43915e88ec8f84486fb6->leave($__internal_0765c70447bd69f9422f5559cf54261edb2da6f417cb43915e88ec8f84486fb6_prof);

        
        $__internal_c41952538ba01d27b9e32c8b5f66f1b5e23418a31b21da2d049a9189c8fc9c02->leave($__internal_c41952538ba01d27b9e32c8b5f66f1b5e23418a31b21da2d049a9189c8fc9c02_prof);

    }

    // line 20
    public function block_body_id($context, array $blocks = array())
    {
        $__internal_1895cd2ad9952d4df6f1f8435f75b9c3868473baa3fada6ddc8f88f3db6795d5 = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_1895cd2ad9952d4df6f1f8435f75b9c3868473baa3fada6ddc8f88f3db6795d5->enter($__internal_1895cd2ad9952d4df6f1f8435f75b9c3868473baa3fada6ddc8f88f3db6795d5_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "body_id"));

        $__internal_e4b5e4ca63a8b88e6216e9e4d54280024b7bc934525ab1033e9f43c47d241039 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_e4b5e4ca63a8b88e6216e9e4d54280024b7bc934525ab1033e9f43c47d241039->enter($__internal_e4b5e4ca63a8b88e6216e9e4d54280024b7bc934525ab1033e9f43c47d241039_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "body_id"));

        
        $__internal_e4b5e4ca63a8b88e6216e9e4d54280024b7bc934525ab1033e9f43c47d241039->leave($__internal_e4b5e4ca63a8b88e6216e9e4d54280024b7bc934525ab1033e9f43c47d241039_prof);

        
        $__internal_1895cd2ad9952d4df6f1f8435f75b9c3868473baa3fada6ddc8f88f3db6795d5->leave($__internal_1895cd2ad9952d4df6f1f8435f75b9c3868473baa3fada6ddc8f88f3db6795d5_prof);

    }

    // line 21
    public function block_body($context, array $blocks = array())
    {
        $__internal_a2f6047bb99843c3fd1667bf70ad2fd02f0f416ab6009731a919ba9464407e9b = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_a2f6047bb99843c3fd1667bf70ad2fd02f0f416ab6009731a919ba9464407e9b->enter($__internal_a2f6047bb99843c3fd1667bf70ad2fd02f0f416ab6009731a919ba9464407e9b_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "body"));

        $__internal_e8e9cc66f4a8c2f5f191c09a115c2ab90780e1d067c5e40a1216c26605a013df = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_e8e9cc66f4a8c2f5f191c09a115c2ab90780e1d067c5e40a1216c26605a013df->enter($__internal_e8e9cc66f4a8c2f5f191c09a115c2ab90780e1d067c5e40a1216c26605a013df_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "body"));

        // line 22
        echo "    ";
        $this->displayBlock('main', $context, $blocks);
        
        $__internal_e8e9cc66f4a8c2f5f191c09a115c2ab90780e1d067c5e40a1216c26605a013df->leave($__internal_e8e9cc66f4a8c2f5f191c09a115c2ab90780e1d067c5e40a1216c26605a013df_prof);

        
        $__internal_a2f6047bb99843c3fd1667bf70ad2fd02f0f416ab6009731a919ba9464407e9b->leave($__internal_a2f6047bb99843c3fd1667bf70ad2fd02f0f416ab6009731a919ba9464407e9b_prof);

    }

    public function block_main($context, array $blocks = array())
    {
        $__internal_302748b5b28c78e0eef859e68ff47a0095071a0447738853dee6e565dbce89db = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_302748b5b28c78e0eef859e68ff47a0095071a0447738853dee6e565dbce89db->enter($__internal_302748b5b28c78e0eef859e68ff47a0095071a0447738853dee6e565dbce89db_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "main"));

        $__internal_22230716241e9d8619a7f2f70157358ce9f6bf9a5b099308959361ce4833d7c2 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_22230716241e9d8619a7f2f70157358ce9f6bf9a5b099308959361ce4833d7c2->enter($__internal_22230716241e9d8619a7f2f70157358ce9f6bf9a5b099308959361ce4833d7c2_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "main"));

        
        $__internal_22230716241e9d8619a7f2f70157358ce9f6bf9a5b099308959361ce4833d7c2->leave($__internal_22230716241e9d8619a7f2f70157358ce9f6bf9a5b099308959361ce4833d7c2_prof);

        
        $__internal_302748b5b28c78e0eef859e68ff47a0095071a0447738853dee6e565dbce89db->leave($__internal_302748b5b28c78e0eef859e68ff47a0095071a0447738853dee6e565dbce89db_prof);

    }

    public function getTemplateName()
    {
        return "base.html.twig";
    }

    public function isTraitable()
    {
        return false;
    }

    public function getDebugInfo()
    {
        return array (  138 => 22,  129 => 21,  112 => 20,  99 => 15,  97 => 14,  95 => 13,  86 => 12,  68 => 11,  56 => 24,  54 => 21,  50 => 20,  43 => 17,  41 => 12,  37 => 11,  30 => 6,);
    }

    /** @deprecated since 1.27 (to be removed in 2.0). Use getSourceContext() instead */
    public function getSource()
    {
        @trigger_error('The '.__METHOD__.' method is deprecated since version 1.27 and will be removed in 2.0. Use getSourceContext() instead.', E_USER_DEPRECATED);

        return $this->getSourceContext()->getCode();
    }

    public function getSourceContext()
    {
        return new Twig_Source("{#
   This is the base template used as the application layout which contains the
   common elements and decorates all the other templates.
   See http://symfony.com/doc/current/book/templating.html#template-inheritance-and-layouts
#}
<!DOCTYPE html>
<html lang=\"en-US\">
<head>
    <meta charset=\"UTF-8\"/>
    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1\"/>
    <title>{% block title %}Anime List{% endblock %}</title>
    {% block stylesheets %}
        {#<link rel=\"stylesheet\" href=\"{{ asset('css/reset-style.css') }}\">;#}
        {#<link rel=\"stylesheet\" href=\"https://maxcdn.bootstrapcdn.com/font-awesome/4.7.0/css/font-awesome.min.css\">#}
        <link rel=\"stylesheet\" href=\"{{ asset('css/style.css') }}\">
    {% endblock %}
    <link rel=\"icon\" type=\"image/x-icon\" href=\"{{ asset('favicon.ico') }}\"/>
</head>

<body id=\"{% block body_id %}{% endblock %}\">
{% block body %}
    {% block main %}{% endblock %}
{% endblock %}
</body>
</html>
", "base.html.twig", "D:\\PHP Solution\\app\\Resources\\views\\base.html.twig");
    }
}

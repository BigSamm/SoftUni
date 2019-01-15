<?php

/* :task:create.html.twig */
class __TwigTemplate_c517018ef399f95051010888a14e5980d898b696f6e7aa2f05f5a4a39fa0338c extends Twig_Template
{
    public function __construct(Twig_Environment $env)
    {
        parent::__construct($env);

        // line 1
        $this->parent = $this->loadTemplate("base.html.twig", ":task:create.html.twig", 1);
        $this->blocks = array(
            'main' => array($this, 'block_main'),
        );
    }

    protected function doGetParent(array $context)
    {
        return "base.html.twig";
    }

    protected function doDisplay(array $context, array $blocks = array())
    {
        $__internal_cbbfbf9e76d98742114d44f20d33ba13e3d11f1df9cb2430e9dc81227f658c70 = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_cbbfbf9e76d98742114d44f20d33ba13e3d11f1df9cb2430e9dc81227f658c70->enter($__internal_cbbfbf9e76d98742114d44f20d33ba13e3d11f1df9cb2430e9dc81227f658c70_prof = new Twig_Profiler_Profile($this->getTemplateName(), "template", ":task:create.html.twig"));

        $__internal_50277551933a2741f6c40d2df710df9f462f8e1a9ff3cc00dea62ecf31d1a452 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_50277551933a2741f6c40d2df710df9f462f8e1a9ff3cc00dea62ecf31d1a452->enter($__internal_50277551933a2741f6c40d2df710df9f462f8e1a9ff3cc00dea62ecf31d1a452_prof = new Twig_Profiler_Profile($this->getTemplateName(), "template", ":task:create.html.twig"));

        $this->parent->display($context, array_merge($this->blocks, $blocks));
        
        $__internal_cbbfbf9e76d98742114d44f20d33ba13e3d11f1df9cb2430e9dc81227f658c70->leave($__internal_cbbfbf9e76d98742114d44f20d33ba13e3d11f1df9cb2430e9dc81227f658c70_prof);

        
        $__internal_50277551933a2741f6c40d2df710df9f462f8e1a9ff3cc00dea62ecf31d1a452->leave($__internal_50277551933a2741f6c40d2df710df9f462f8e1a9ff3cc00dea62ecf31d1a452_prof);

    }

    // line 3
    public function block_main($context, array $blocks = array())
    {
        $__internal_44e833f93dadb34a8846894237488432fe68951353a31cff662d51858dfc5d5b = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_44e833f93dadb34a8846894237488432fe68951353a31cff662d51858dfc5d5b->enter($__internal_44e833f93dadb34a8846894237488432fe68951353a31cff662d51858dfc5d5b_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "main"));

        $__internal_c22c7c2f2617a80231cb7821f9408db480a71bec21055cef35a4aba9908cf999 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_c22c7c2f2617a80231cb7821f9408db480a71bec21055cef35a4aba9908cf999->enter($__internal_c22c7c2f2617a80231cb7821f9408db480a71bec21055cef35a4aba9908cf999_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "main"));

        // line 4
        echo "    <header>
        <h3>Create New Task</h3>
    </header>

    <form method=\"post\">
        <div>
            <label class=\"desc\" for=\"title\">Title</label>
            <div>
                <input id=\"title\" name=\"task[title]\" type=\"text\" class=\"field text fn\" value=\"\" size=\"8\" tabindex=\"1\"
                       autofocus>
            </div>
        </div>

        <div>
            <fieldset>
                <legend class=\"desc\">
                    Status
                </legend>

                <div>
                    <div>
                        <input id=\"status1\" name=\"task[status]\" type=\"radio\" value=\"Open\" tabindex=\"2\" checked>
                        <label class=\"choice\" for=\"status1\">Open</label>
                    </div>
                    <div>
                        <input id=\"status2\" name=\"task[status]\" type=\"radio\" value=\"In Progress\" tabindex=\"3\">
                        <label class=\"choice\" for=\"status2\">In Progress</label>
                    </div>
                    <div>
                        <input id=\"status3\" name=\"task[status]\" type=\"radio\" value=\"Finished\" tabindex=\"4\">
                        <label class=\"choice\" for=\"status3\">Finished</label>
                    </div>
                </div>
            </fieldset>
        </div>

        <div>
            <div>
                <input class=\"button\" type=\"submit\" value=\"Submit\">
                <a class=\"button cancel\" href=\"/\">Cancel</a>
            </div>
        </div>

        ";
        // line 47
        echo $this->env->getRuntime('Symfony\Bridge\Twig\Form\TwigRenderer')->searchAndRenderBlock($this->getAttribute(($context["form"] ?? $this->getContext($context, "form")), "_token", array()), 'row');
        echo "
    </form>
";
        
        $__internal_c22c7c2f2617a80231cb7821f9408db480a71bec21055cef35a4aba9908cf999->leave($__internal_c22c7c2f2617a80231cb7821f9408db480a71bec21055cef35a4aba9908cf999_prof);

        
        $__internal_44e833f93dadb34a8846894237488432fe68951353a31cff662d51858dfc5d5b->leave($__internal_44e833f93dadb34a8846894237488432fe68951353a31cff662d51858dfc5d5b_prof);

    }

    public function getTemplateName()
    {
        return ":task:create.html.twig";
    }

    public function isTraitable()
    {
        return false;
    }

    public function getDebugInfo()
    {
        return array (  94 => 47,  49 => 4,  40 => 3,  11 => 1,);
    }

    /** @deprecated since 1.27 (to be removed in 2.0). Use getSourceContext() instead */
    public function getSource()
    {
        @trigger_error('The '.__METHOD__.' method is deprecated since version 1.27 and will be removed in 2.0. Use getSourceContext() instead.', E_USER_DEPRECATED);

        return $this->getSourceContext()->getCode();
    }

    public function getSourceContext()
    {
        return new Twig_Source("{% extends \"base.html.twig\" %}

{% block main %}
    <header>
        <h3>Create New Task</h3>
    </header>

    <form method=\"post\">
        <div>
            <label class=\"desc\" for=\"title\">Title</label>
            <div>
                <input id=\"title\" name=\"task[title]\" type=\"text\" class=\"field text fn\" value=\"\" size=\"8\" tabindex=\"1\"
                       autofocus>
            </div>
        </div>

        <div>
            <fieldset>
                <legend class=\"desc\">
                    Status
                </legend>

                <div>
                    <div>
                        <input id=\"status1\" name=\"task[status]\" type=\"radio\" value=\"Open\" tabindex=\"2\" checked>
                        <label class=\"choice\" for=\"status1\">Open</label>
                    </div>
                    <div>
                        <input id=\"status2\" name=\"task[status]\" type=\"radio\" value=\"In Progress\" tabindex=\"3\">
                        <label class=\"choice\" for=\"status2\">In Progress</label>
                    </div>
                    <div>
                        <input id=\"status3\" name=\"task[status]\" type=\"radio\" value=\"Finished\" tabindex=\"4\">
                        <label class=\"choice\" for=\"status3\">Finished</label>
                    </div>
                </div>
            </fieldset>
        </div>

        <div>
            <div>
                <input class=\"button\" type=\"submit\" value=\"Submit\">
                <a class=\"button cancel\" href=\"/\">Cancel</a>
            </div>
        </div>

        {{ form_row(form._token) }}
    </form>
{% endblock %}", ":task:create.html.twig", "D:\\PHP Skeleton 2\\app/Resources\\views/task/create.html.twig");
    }
}
